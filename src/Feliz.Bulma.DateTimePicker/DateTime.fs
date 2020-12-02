﻿namespace Feliz.Bulma.DateTimePicker

open System
open Fable.Core
open Fable.DateFunctions
open Feliz
open Feliz.Bulma.DateTimePicker
open Feliz.Bulma.Operators
open Feliz.Bulma

module internal DatePicker =
    type Props =
        abstract onDateSelected: (DateTime option -> unit) option
        abstract onDateRangeSelected: ((DateTime * DateTime) option -> unit) option
        abstract defaultValue: DateTime option
        abstract defaultRangeValue: (DateTime * DateTime) option
        abstract isRange : bool
        abstract displayMode : DisplayMode
        abstract clearLabel : string
        abstract locale : ILocale
        abstract dateFromLabel : string
        abstract dateToLabel : string
        abstract minDate: DateTime option
        abstract maxDate: DateTime option
        abstract dateOnly : bool

    type private DateTimeValue = { Date : DateTime option; Time : TimeSpan option }

    let private datePickerSelection (l:ILocale) (d:DateTimeValue) =
        let day = d.Date |> Option.map (fun x -> x.Day) |> Option.map string |> Option.defaultValue "-"
        let yearMonth = d.Date |> Option.map (fun x -> x.Format("MMMM yyyy", l)) |> Option.defaultValue ""
        let dayText = d.Date |> Option.map (fun x -> x.Format("E", l)) |> Option.defaultValue ""
        Html.divClassed "datetimepicker-selection-wrapper" [
            Html.divClassed "datetimepicker-selection-day" [ Html.text day ]
            Html.divClassed "datetimepicker-selection-date" [
                Html.divClassed "datetimepicker-selection-month" [ Html.text yearMonth ]
                Html.divClassed "datetimepicker-selection-weekday" [ Html.text dayText ]
            ]
        ]

    let private datePickerTimeSelection (l:ILocale) (d:DateTimeValue) =
        let time = d.Time |> Option.map TimePicker.toFormattedTime |> Option.defaultValue "-"
        Html.divClassed "datetimepicker-selection-time" [
            Html.divClassed "datetimepicker-selection-time-icon" [
                Html.figure [
                    prop.style [ style.opacity 0.5 ]
                    prop.className "image is-16x16"
                    prop.children [
                        Html.i [ prop.className "far fa-clock" ++ color.hasTextGrey ]
                    ]
                ]
            ]
            Html.divClassed "datetimepicker-selection-hour" [ Html.text time ]
        ]

    let private weekRange (l:ILocale) (d:DateTime) =
        let fstDate = d.StartOfMonth().StartOfWeek(l)
        [0..6]
        |> List.map (fun i ->
            fstDate.AddDays i
        )
        |> List.map (fun d -> d.Format("EEE", l))

    let private monthRange (l:ILocale) (d:DateTime) =
        let fstDate = d.StartOfMonth().StartOfWeek(l)
        [0..34]
        |> List.map (fun x -> fstDate.AddDays(x))
        |> (fun dates ->
            if (dates.[34]).AddDays(1).IsInTheSameMonthAs(d) then
                [35..41]
                |> List.map (fun x -> fstDate.AddDays(x))
                |> (fun newDates -> dates @ newDates)
            else dates
        )

    type private EditMode =
        | Date
        | Month
        | Year
        with
            member x.IsDateMode() = x = Date
            member x.IsMonthMode() = x = Month
            member x.IsYearMode() = x = Year

    [<RequireQualifiedAccess>]
    module private DateTimeValue =
        let date (dtv:DateTimeValue) = dtv.Date
        let fromDateTime (d:DateTime) = { Date = Some d.Date; Time = Some d.TimeOfDay }
        let tryToDateTime (dtv:DateTimeValue) =
            match dtv.Date, dtv.Time with
            | Some d, Some t -> Some <| d.Date.Add(t)
            | _ -> None

        let applyDate (dtv:DateTimeValue) (d:DateTime) = { dtv with Date = Some d.Date }
        let applyTime (dtv:DateTimeValue) (t:TimeSpan) = { dtv with Time = Some t }
        let withoutDate (dtv:DateTimeValue) = { dtv with Date = None }

        let empty = { Date = None; Time = None }
        let isComplete (dtv:DateTimeValue) =
            dtv.Date.IsSome && dtv.Time.IsSome
            || dtv = empty

    type private SelectedValue = DateTimeValue * DateTimeValue

    [<RequireQualifiedAccess>]
    module private SelectedValue =
        let fromRangeValue rv : SelectedValue =
            rv
            |> Option.map (fun (s,e) -> DateTimeValue.fromDateTime s, DateTimeValue.fromDateTime e)
            |> Option.defaultValue (DateTimeValue.empty, DateTimeValue.empty)

        let ensureDatesSort (sv:SelectedValue) : SelectedValue =
            match sv with
            | { Date = Some d1 }, { Date = Some d2 } ->
                if d1 > d2 then
                    (d2 |> DateTimeValue.applyDate (fst sv)), (d1 |> DateTimeValue.applyDate (snd sv))
                else sv
            | _ -> sv

        let isRangeComplete (sv:SelectedValue) =
            sv |> fst |> DateTimeValue.isComplete
            &&
            sv |> snd |> DateTimeValue.isComplete

        let getRangeValue (sv:SelectedValue) =
            match sv |> fst |> DateTimeValue.tryToDateTime, sv |> snd |> DateTimeValue.tryToDateTime with
            | Some s, Some e -> Some (s, e)
            | _ -> None

        let applyDateSelectionOnRange (sv:SelectedValue) (d:DateTime) : SelectedValue =
            match sv with
            | { Date = Some _ }, { Date = None } -> (fst sv), (d |> DateTimeValue.applyDate (snd sv))
            | f, t -> (d |> DateTimeValue.applyDate f), (t |> DateTimeValue.withoutDate)
            |> ensureDatesSort

        let applyTimeSelectionOnRange (sv:SelectedValue) (s,e) : SelectedValue =
            s |> DateTimeValue.applyTime (sv |> fst)
            ,
            e |> DateTimeValue.applyTime (sv |> snd)

        let fromSingleValue s : SelectedValue =
            s
            |> Option.map DateTimeValue.fromDateTime
            |> Option.map (fun x -> x, x)
            |> Option.defaultValue (DateTimeValue.empty, DateTimeValue.empty)

        let isSingleValueComplete (sv:SelectedValue) =
            sv |> fst |> DateTimeValue.isComplete

        let getSingleValue (sv:SelectedValue) =
            sv |> fst |> DateTimeValue.tryToDateTime

        let applyDateSelectionOnSingle (sv:SelectedValue) (d:DateTime) : SelectedValue =
            let f,_ = sv
            (d |> DateTimeValue.applyDate f), DateTimeValue.empty

        let applyTimeSelectionOnSingle (sv:SelectedValue) (s,_) : SelectedValue =
            s |> DateTimeValue.applyTime (sv |> fst), DateTimeValue.empty

        let empty = DateTimeValue.empty, DateTimeValue.empty


    [<ReactComponent>]
    let dateTimePicker (p:Props) =
        let myRef = React.useElementRef()

        let defaultValue =
            if p.isRange then p.defaultRangeValue |> SelectedValue.fromRangeValue
            else p.defaultValue |> SelectedValue.fromSingleValue

        let value, setValue = React.useState(defaultValue)

        let isDisplayed, setIsDisplayed =
            match p.displayMode with
            | DisplayMode.Default -> React.useState(false)
            | DisplayMode.Inline ->
                let _,_ = React.useState(false)
                true,ignore

        let currentMonth, setCurrentMonth =
            match value |> fst with
            | { Date = Some v } -> React.useState(v.StartOfMonth())
            | _ -> React.useState(DateTime.UtcNow.StartOfMonth())

        let editMode, setEditMode = React.useState(EditMode.Date)

        Hook.useOnClickOutside(myRef, fun _ -> setIsDisplayed false)

        let updateDate (s:SelectedValue) =
            s |> setValue
            if p.isRange && s |> SelectedValue.isRangeComplete && p.onDateRangeSelected.IsSome then
                s |> SelectedValue.getRangeValue |> p.onDateRangeSelected.Value
            if not p.isRange && s |> SelectedValue.isSingleValueComplete && p.onDateSelected.IsSome then
                s |> SelectedValue.getSingleValue |> p.onDateSelected.Value

        let onCurrentMonthSelected (d:DateTime) =
            EditMode.Date |> setEditMode
            d |> setCurrentMonth

        let onDateSelected (d:DateTime) =
            if p.isRange then
                d |> SelectedValue.applyDateSelectionOnRange value
            else
                d |> SelectedValue.applyDateSelectionOnSingle value
            |> updateDate

        let onClear _ =
            SelectedValue.empty |> updateDate

        let onTimeSelected (f:TimeSpan, t:TimeSpan) =
            if p.isRange then
                (f,t) |> SelectedValue.applyTimeSelectionOnRange value
            else
                (f,t) |> SelectedValue.applyTimeSelectionOnSingle value
            |> updateDate

        let timeValue =
            (value |> fst |> (fun x -> x.Time) |> Option.defaultValue TimeSpan.Zero),
            (value |> snd |> (fun x -> x.Time) |> Option.defaultValue TimeSpan.Zero)

        let sh,sm,eh,em = timeValue |> TimePicker.toHrsMins
        let updateHoursStart (i:int) = (i,sm,eh,em) |> TimePicker.toTimeSpans |> onTimeSelected
        let updateMinutesStart (i:int) = (sh,i,eh,em) |> TimePicker.toTimeSpans |> onTimeSelected
        let updateHoursEnd (i:int) = (sh,sm,i,em) |> TimePicker.toTimeSpans |> onTimeSelected
        let updateMinutesEnd (i:int) = (sh,sm,eh,i) |> TimePicker.toTimeSpans |> onTimeSelected

        let body = [
            Html.divClassed "datetimepicker-container" [
                // header
                Html.divClassed ("datetimepicker-header " + if p.dateOnly then "is-date-only" else "") [
                    Html.divClassed "datetimepicker-selection-details" [
                        Html.divClassed "datetimepicker-selection-from" [ Html.text p.dateFromLabel ]
                        Html.div [
                            prop.classes [
                                "datetimepicker-selection-start"
                                if not p.isRange then "is-centered"
                            ]
                            prop.children [
                                datePickerSelection p.locale <| (value |> fst)
                                if not p.dateOnly then
                                    datePickerTimeSelection p.locale <| (value |> fst)
                            ]
                        ]
                    ]
                    if p.isRange then
                        Html.divClassed "datetimepicker-selection-details" [
                            Html.divClassed "datetimepicker-selection-to" [ Html.text p.dateToLabel ]
                            Html.divClassed "datetimepicker-selection-end" [
                                datePickerSelection p.locale <| (value |> snd)
                                if not p.dateOnly then
                                    datePickerTimeSelection p.locale <| (value |> snd)
                            ]
                        ]
                ]
                // picker
                Html.divClassed "datepicker" [
                    // navigation
                    Html.divClassed "datepicker-nav" [
                        Html.button [
                            prop.className "datepicker-nav-previous button is-small is-text"
                            prop.children [
                                Html.i [ prop.className "fas fa-chevron-left" ]
                            ]
                            prop.onClick (fun _ -> onCurrentMonthSelected <| currentMonth.StartOfPreviousMonth())
                        ]
                        Html.divClassed "datepicker-nav-month-year" [
                            Html.div [
                                prop.className "datepicker-nav-month"
                                prop.onClick (fun _ -> EditMode.Month |> setEditMode)
                                prop.children [ Html.text (currentMonth.Format("LLLL", p.locale)) ]
                            ]
                            Html.div [ prop.dangerouslySetInnerHTML "&nbsp;" ]
                            Html.div [
                                prop.className "datepicker-nav-year"
                                prop.onClick (fun _ -> EditMode.Year |> setEditMode)
                                prop.children [ Html.text (currentMonth.Format("yyyy", p.locale)) ]
                            ]
                        ]
                        Html.button [
                            prop.className "datepicker-nav-next button is-small is-text"
                            prop.children [
                                Html.i [ prop.className "fas fa-chevron-right" ]
                            ]
                            prop.onClick (fun _ -> onCurrentMonthSelected <| currentMonth.StartOfNextMonth())
                        ]
                    ]
                    // body
                    Html.divClassed "datepicker-body" [
                        Html.div [
                            prop.classes [
                                "datepicker-dates"
                                if editMode.IsDateMode() then "is-active"
                            ]
                            prop.children [
                                Html.divClassed "datepicker-weekdays" [
                                    for w in weekRange p.locale currentMonth do
                                        Html.div [
                                            prop.className "datepicker-date"
                                            prop.text w
                                            prop.style [style.textTransform.capitalize]
                                        ]
                                ]
                                Html.divClassed "datepicker-days" [
                                    for d in monthRange p.locale currentMonth do
                                        let isCurrentMonth = d.IsInTheSameMonthAs(currentMonth)
                                        let isInRange =
                                            match (fst value), (snd value) with
                                            | { Date = Some s }, { Date = Some e } -> d.IsBetween(s, e)
                                            | _ -> false
                                        let isStartSelected =
                                            value
                                            |> fst
                                            |> DateTimeValue.date
                                            |> Option.map (fun x -> x.IsInTheSameDayAs(d))
                                            |> Option.defaultValue false
                                        let isEndSelected =
                                            value
                                            |> snd
                                            |> DateTimeValue.date
                                            |> Option.map (fun x -> x.IsInTheSameDayAs(d))
                                            |> Option.defaultValue false
                                        let isDisabled =
                                            (d < (p.minDate |> Option.map (fun x -> x.StartOfDay()) |> Option.defaultValue (DateTime.MinValue.StartOfDay())))
                                            ||
                                            (d > (p.maxDate |> Option.map (fun x -> x.StartOfDay()) |> Option.defaultValue (DateTime.MaxValue.StartOfDay())))

                                        Html.div [
                                            prop.classes [
                                                "datepicker-date"
                                                if isCurrentMonth then "is-current-month"
                                                if isStartSelected then "datepicker-range-start"
                                                if isEndSelected then "datepicker-range-end"
                                                if isInRange then "datepicker-range"
                                                if isDisabled then "is-disabled"
                                            ]
                                            prop.children [
                                                Html.button [
                                                    prop.classes [
                                                        "date-item"
                                                        if d.IsToday() then "is-today"
                                                        if isStartSelected then "is-active"
                                                    ]
                                                    prop.text (d.Day)
                                                    prop.type'.button
                                                    prop.onClick (fun _ -> d |> onDateSelected)
                                                ]
                                            ]
                                        ]
                                ]
                            ]
                        ]
                        // months
                        Html.div [
                            prop.classes [
                                "datepicker-months"
                                if editMode.IsMonthMode() then "is-active"
                            ]
                            prop.children [
                                for i in [1..12] do
                                    let month = DateTime(currentMonth.Year, i, currentMonth.Day)
                                    let isSameMonth = i = currentMonth.Month
                                    Html.div [
                                        prop.classes [ "datepicker-month"; if isSameMonth then "is-active" ]
                                        prop.text (month.Format("LLL", p.locale))
                                        prop.onClick (fun _ -> month |> onCurrentMonthSelected)
                                    ]
                            ]
                        ]
                        // years
                        Html.div [
                            prop.classes [
                                "datepicker-years"
                                if editMode.IsYearMode() then "is-active"
                            ]
                            prop.children [
                                for i in [-50..50] do
                                    let year = DateTime(currentMonth.Year + i, currentMonth.Month, 1)
                                    let isSameYear = year.IsInTheSameYearAs(currentMonth)
                                    Html.div [
                                        prop.classes [ "datepicker-year"; if isSameYear then "is-active" ]
                                        prop.text year.Year
                                        prop.onClick (fun _ -> year |> onCurrentMonthSelected)
                                    ]
                            ]
                        ]
                    ]
                ]
                // timepicker
                if not p.dateOnly then

                    Html.divClassed "timepicker" [
                        Html.divClassed "timepicker-start" [
                            TimePicker.timePickerHours sh updateHoursStart
                            Html.divClassed "timepicker-time-divider" [ Html.text ":" ]
                            TimePicker.timePickerMinutes sm updateMinutesStart
                        ]
                        if p.isRange then
                            Html.divClassed "timepicker-end" [
                                TimePicker.timePickerHours eh updateHoursEnd
                                Html.divClassed "timepicker-time-divider" [ Html.text ":" ]
                                TimePicker.timePickerMinutes em updateMinutesEnd
                            ]
                    ]
            ]
            Html.divClassed "datetimepicker-footer" [
                Html.button [
                    prop.classes [ "datetimepicker-footer-clear"; "has-text-danger"; "button"; "is-small"; "is-text" ]
                    prop.type' "button"
                    prop.text p.clearLabel
                    prop.onClick onClear
                ]
            ]
        ]
        let value =
            if p.isRange then
                match (value |> fst |> DateTimeValue.tryToDateTime), (value |> snd |> DateTimeValue.tryToDateTime) with
                | Some s, Some e -> sprintf "%s - %s" (s.Format("dd. MMMM yyyy", p.locale)) (e.Format("dd. MMMM yyyy", p.locale))
                | _ -> ""
            else
                value
                |> fst
                |> DateTimeValue.tryToDateTime
                |> Option.map (fun x -> x.Format("dd. MMMM yyyy", p.locale))
                |> Option.defaultValue ""

        let input =
            match p.displayMode with
            | DisplayMode.Default ->
                Bulma.control.div [
                    control.hasIconsLeft
                    prop.children [
                        Bulma.input.text [
                            prop.readOnly true
                            prop.valueOrDefault value
                            prop.onClick (fun _ -> setIsDisplayed true)
                        ]
                        Bulma.icon [
                            icon.isLeft
                            prop.style [ style.zIndex 0 ]
                            prop.children [ Html.i [ prop.className "far fa-calendar-alt" ++ color.hasTextGrey ] ]
                        ]
                    ]
                ]
            | DisplayMode.Inline -> Html.none

        Html.div [
            input
            body |> Layout.wrapper isDisplayed p.displayMode myRef
        ]

type IDateTimePickerProperty = interface end

[<Erase>]
type dateTimePicker =
    static member inline onDateSelected (eventHandler: DateTime option -> unit) : IDateTimePickerProperty = unbox ("onDateSelected", eventHandler)
    static member inline onDateRangeSelected (eventHandler: (DateTime * DateTime) option -> unit) : IDateTimePickerProperty = unbox ("onDateRangeSelected", eventHandler)
    static member inline defaultValue (v:DateTime option) : IDateTimePickerProperty = unbox ("defaultValue", v)
    static member inline defaultRangeValue (v:(DateTime * DateTime) option) : IDateTimePickerProperty = unbox ("defaultRangeValue", v)
    static member inline isRange (v:bool) : IDateTimePickerProperty = unbox ("isRange", v)
    static member inline displayMode (v:DisplayMode) : IDateTimePickerProperty = unbox ("displayMode", v)
    static member inline clearLabel (v:string) : IDateTimePickerProperty = unbox ("clearLabel", v)
    static member inline locale (v:ILocale) : IDateTimePickerProperty = unbox ("locale", v)
    static member inline dateFromLabel (v:string) : IDateTimePickerProperty = unbox ("dateFromLabel", v)
    static member inline dateToLabel (v:string) : IDateTimePickerProperty = unbox ("dateToLabel", v)
    static member inline minDate (v:DateTime) : IDateTimePickerProperty = unbox ("minDate", v)
    static member inline maxDate (v:DateTime) : IDateTimePickerProperty = unbox ("maxDate", v)
    static member inline dateOnly (v:bool) : IDateTimePickerProperty = unbox ("dateOnly", v)