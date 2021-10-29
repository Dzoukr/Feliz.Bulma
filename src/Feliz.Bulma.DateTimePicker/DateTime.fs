namespace Feliz.Bulma

open System
open System.Globalization
open Browser.Types
open Fable.Core
open Fable.DateFunctions
open Feliz
open Feliz.Bulma.Operators
open Feliz.Bulma

[<RequireQualifiedAccess; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module DatePicker =
    type Props =
        abstract onDateSelected: (DateTime option -> unit) option
        abstract onDateRangeSelected: ((DateTime * DateTime) option -> unit) option
        abstract onShow: (unit -> unit) option
        abstract onHide: (unit -> unit) option
        abstract defaultValue: DateTime option
        abstract defaultRangeValue: (DateTime * DateTime) option
        abstract isRange : bool
        abstract displayMode : DisplayMode
        abstract clearLabel : string
        abstract dateFormat : string option
        abstract locale : ILocale
        abstract dateFromLabel : string
        abstract dateToLabel : string
        abstract minDate: DateTime option
        abstract maxDate: DateTime option
        abstract dateOnly : bool
        abstract allowTextInput : bool
        abstract closeOnSelect: bool

    type private DateTimeValue = { Date : DateTime option; Time : TimeSpan option }


    [<Literal>]
    let private defaultDateFormat = "dd. MMMM yyyy"

    [<Literal>]
    let private defaultDateTimeFormat = "dd. MMMM yyyy"

    type ParseOptsImpl() =
        interface ParseOpts with
            member val additionalDigits = 0 with get, set

    [<Import("parse", "date-fns")>]
    let parseDate (input: string) (format:string) (referenceDate: int) : DateTime = jsNative

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
        let tryToDateTime dateOnly (dtv:DateTimeValue) =
            match dateOnly, dtv.Date, dtv.Time with
            | false, Some d, Some t -> Some <| d.Date.Add(t)
            | true, Some d, _ -> Some <| d.Date
            | _ -> None

        let applyDate (dtv:DateTimeValue) (d:DateTime) = { dtv with Date = Some d.Date }
        let applyTime (dtv:DateTimeValue) (t:TimeSpan) = { dtv with Time = Some t }
        let withoutDate (dtv:DateTimeValue) = { dtv with Date = None }
        let empty = { Date = None; Time = None }
        let isComplete dateOnly (dtv:DateTimeValue) =
            if dateOnly then true
            else
                dtv.Date.IsSome && dtv.Time.IsSome
                || dtv = empty

    type private SelectedValue = { From : DateTimeValue; To : DateTimeValue }

    [<RequireQualifiedAccess>]
    module private SelectedValue =
        let fromRangeValue rv : SelectedValue =
            rv
            |> Option.map (fun (s,e) -> { From = DateTimeValue.fromDateTime s; To = DateTimeValue.fromDateTime e })
            |> Option.defaultValue ({ From = DateTimeValue.empty; To = DateTimeValue.empty })

        let ensureDatesSort (sv:SelectedValue) : SelectedValue =
            match sv.From, sv.To with
            | { Date = Some d1 }, { Date = Some d2 } ->
                if d1 > d2 then
                    { From = d2 |> DateTimeValue.applyDate sv.From; To = d1 |> DateTimeValue.applyDate sv.To }
                else sv
            | _ -> sv

        let isRangeComplete dateOnly (sv:SelectedValue) =
            sv.From |> DateTimeValue.isComplete dateOnly
            &&
            sv.To |> DateTimeValue.isComplete dateOnly

        let getRangeValue dateOnly (sv:SelectedValue) =
            match sv.From |> DateTimeValue.tryToDateTime dateOnly, sv.To |> DateTimeValue.tryToDateTime dateOnly with
            | Some s, Some e -> Some (s, e)
            | _ -> None

        let applyDateSelectionOnRange (sv:SelectedValue) (d:DateTime) : SelectedValue =
            match sv.From, sv.To with
            | { Date = Some _ }, { Date = None } -> { From = sv.From; To = (d |> DateTimeValue.applyDate sv.To) }
            | f, t -> { From = d |> DateTimeValue.applyDate f; To = (t |> DateTimeValue.withoutDate) }
            |> ensureDatesSort

        let applyTimeSelectionOnRange (sv:SelectedValue) (s,e) : SelectedValue =
            { From = s |> DateTimeValue.applyTime (sv.From); To = e |> DateTimeValue.applyTime (sv.To) }

        let empty = { From = DateTimeValue.empty; To = DateTimeValue.empty }

        let fromSingleValue s : SelectedValue =
            s
            |> Option.map DateTimeValue.fromDateTime
            |> Option.map (fun x -> { From = x; To = x})
            |> Option.defaultValue (empty)

        let isSingleValueComplete dateOnly (sv:SelectedValue) =
            sv.From |> DateTimeValue.isComplete dateOnly

        let getSingleValue dateOnly (sv:SelectedValue) =
            sv.From |> DateTimeValue.tryToDateTime dateOnly

        let applyDateSelectionOnSingle (sv:SelectedValue) (d:DateTime) : SelectedValue =
            { From = d |> DateTimeValue.applyDate sv.From; To = DateTimeValue.empty }

        let applyTimeSelectionOnSingle (sv:SelectedValue) (s,_) : SelectedValue =
            { From = s |> DateTimeValue.applyTime (sv.From); To = DateTimeValue.empty }



    [<ReactComponent>]
    let dateTimePicker (p:Props) =
        let myRef = React.useElementRef()

        let defaultValue =
            if p.isRange then p.defaultRangeValue |> SelectedValue.fromRangeValue
            else p.defaultValue |> SelectedValue.fromSingleValue

        //if the user wrote something, his input has priority. It is only reset when value is set
        let valueFromInput, setValueFromInput =
            React.useState(None)

        let value, setValue =
            let v, setv = React.useState(defaultValue)
            (v, fun x -> setValueFromInput None ; setv x)

        let isDisplayed, setIsDisplayed =
            match p.displayMode with
            | DisplayMode.Default ->
                let displayed, setDisplayed = React.useState(false)

                displayed, (fun v ->
                    match displayed, v with
                    | (true, false) ->
                        p.onHide |> Option.iter (fun handler -> handler ())
                    | (false, true) ->
                        p.onShow |> Option.iter (fun handler -> handler ())
                    | _ -> ()
                    setDisplayed v)
            | DisplayMode.Inline ->
                let _,_ = React.useState(false)
                true,ignore

        let currentMonth, setCurrentMonth =
            match value.From with
            | { Date = Some v } -> React.useState(v.StartOfMonth())
            | _ -> React.useState(DateTime.UtcNow.StartOfMonth())

        let editMode, setEditMode = React.useState(EditMode.Date)

        Hook.useOnClickOutside(myRef, fun _ -> setIsDisplayed false)

        let updateDate (s:SelectedValue) =
            s |> setValue
            if p.isRange && s |> SelectedValue.isRangeComplete p.dateOnly && p.onDateRangeSelected.IsSome then
                s |> SelectedValue.getRangeValue p.dateOnly |> p.onDateRangeSelected.Value
            if not p.isRange && s |> SelectedValue.isSingleValueComplete p.dateOnly && p.onDateSelected.IsSome then
                s |> SelectedValue.getSingleValue p.dateOnly |> p.onDateSelected.Value

        let onCurrentMonthSelected (d:DateTime) =
            EditMode.Date |> setEditMode
            d |> setCurrentMonth

        let closeOnFilledDate (s:SelectedValue) =
            match (p.closeOnSelect, p.dateOnly, p.isRange, p.displayMode) with
            | (true, true, false, DisplayMode.Default) ->
                setIsDisplayed false
            | (true, true, true, DisplayMode.Default) ->
                if s.From.Date.IsSome && s.To.Date.IsSome then
                    setIsDisplayed false
            | _ ->
                ()
            s

        let onDateSelected (d:DateTime) =
            if p.isRange then
                d |> SelectedValue.applyDateSelectionOnRange value
            else
                d |> SelectedValue.applyDateSelectionOnSingle value
            |> closeOnFilledDate
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
            (value.From |> (fun x -> x.Time) |> Option.defaultValue TimeSpan.Zero),
            (value.To |> (fun x -> x.Time) |> Option.defaultValue TimeSpan.Zero)

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
                                datePickerSelection p.locale value.From
                                if not p.dateOnly then
                                    datePickerTimeSelection p.locale value.From
                            ]
                        ]
                    ]
                    if p.isRange then
                        Html.divClassed "datetimepicker-selection-details" [
                            Html.divClassed "datetimepicker-selection-to" [ Html.text p.dateToLabel ]
                            Html.divClassed "datetimepicker-selection-end" [
                                datePickerSelection p.locale value.To
                                if not p.dateOnly then
                                    datePickerTimeSelection p.locale value.To
                            ]
                        ]
                ]
                // picker
                Html.divClassed "datepicker" [
                    // navigation
                    Html.divClassed "datepicker-nav" [
                        Html.button [
                            prop.type' "button"
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
                            prop.type' "button"
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
                                            match value.From, value.To with
                                            | { Date = Some s }, { Date = Some e } -> d.IsBetween(s, e)
                                            | _ -> false
                                        let isStartSelected =
                                            value.From
                                            |> DateTimeValue.date
                                            |> Option.map (fun x -> x.IsInTheSameDayAs(d))
                                            |> Option.defaultValue false
                                        let isEndSelected =
                                            value.To
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
                                                if p.isRange then
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
        let format (d:DateTime) =
            let formatString =
                match (p.dateFormat, p.dateOnly) with
                | (Some x, _) -> x
                | (None, true) -> defaultDateFormat
                | (None, false) -> defaultDateTimeFormat
            d.Format(formatString, p.locale)

        let canUserWrite = p.allowTextInput && not p.isRange && p.dateOnly

        let txtValue =
            match valueFromInput with
            | Some inp -> inp
            | None ->
                if p.isRange then
                    match (value.From |> DateTimeValue.tryToDateTime p.dateOnly), (value.To |> DateTimeValue.tryToDateTime p.dateOnly) with
                    | Some s, Some e -> sprintf "%s - %s" (format s) (format e)
                    | _ -> ""
                else
                    value.From
                    |> DateTimeValue.tryToDateTime p.dateOnly
                    |> Option.map format
                    |> Option.defaultValue ""

        let tryParseInputDate inputValue =
            try
               let parsedDate =
                   match p.dateFormat with
                   | Some y -> parseDate inputValue y 0
                   | None -> parseDate inputValue defaultDateFormat 0

               if parsedDate.IsValid() then
                   {value with
                            From = { Date = Some parsedDate ; Time = None }
                            To = { Date = None ; Time = None }}
                   |> setValue
                   parsedDate |> setCurrentMonth
               else
                   ()
            with
               | exn -> ()



        let input =
            match p.displayMode with
            | DisplayMode.Default ->
                Bulma.control.div [
                    control.hasIconsLeft
                    prop.children [
                        Bulma.input.text [
                            prop.readOnly (not canUserWrite)
                            prop.onClick (fun _ -> setIsDisplayed true)
                            if canUserWrite then
                                prop.onBlur(fun (evt: FocusEvent) ->
                                    (evt.target :?> HTMLInputElement).value |> tryParseInputDate)
                                prop.onTextChange(fun x -> setValueFromInput (Some x))
                            prop.valueOrDefault txtValue
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
    static member inline onShow (eventHandler: unit -> unit) : IDateTimePickerProperty = unbox ("onShow", eventHandler)
    static member inline onHide (eventHandler: unit -> unit) : IDateTimePickerProperty = unbox ("onHide", eventHandler)
    static member inline defaultValue (v:DateTime) : IDateTimePickerProperty = unbox ("defaultValue", v)
    static member inline defaultRangeValue (v:DateTime * DateTime) : IDateTimePickerProperty = unbox ("defaultRangeValue", v)
    static member inline isRange (v:bool) : IDateTimePickerProperty = unbox ("isRange", v)
    static member inline displayMode (v:DisplayMode) : IDateTimePickerProperty = unbox ("displayMode", v)
    static member inline clearLabel (v:string) : IDateTimePickerProperty = unbox ("clearLabel", v)
    static member inline dateFormat (v:string) : IDateTimePickerProperty = unbox ("dateFormat", v)
    static member inline locale (v:ILocale) : IDateTimePickerProperty = unbox ("locale", v)
    static member inline dateFromLabel (v:string) : IDateTimePickerProperty = unbox ("dateFromLabel", v)
    static member inline dateToLabel (v:string) : IDateTimePickerProperty = unbox ("dateToLabel", v)
    static member inline minDate (v:DateTime) : IDateTimePickerProperty = unbox ("minDate", v)
    static member inline maxDate (v:DateTime) : IDateTimePickerProperty = unbox ("maxDate", v)
    static member inline dateOnly (v:bool) : IDateTimePickerProperty = unbox ("dateOnly", v)
    /// Close the picker when the date is selected, only applicable for DatePicker
    static member inline closeOnSelect (v:bool) : IDateTimePickerProperty = unbox ("closeOnSelect", v)
    static member inline allowTextInput (v:bool) : IDateTimePickerProperty = unbox ("allowTextInput", v)
