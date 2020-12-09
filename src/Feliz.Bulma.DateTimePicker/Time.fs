namespace Feliz.Bulma.DateTimePicker

open System
open Fable.Core
open Feliz
open Feliz.Bulma.Operators
open Feliz.Bulma

[<RequireQualifiedAccess; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module TimePicker =
    type Props =
        abstract onTimeSelected: (TimeSpan option -> unit) option
        abstract onTimeRangeSelected: ((TimeSpan * TimeSpan) option -> unit) option
        abstract onShow: (unit -> unit) option
        abstract onHide: (unit -> unit) option
        abstract defaultValue: TimeSpan option
        abstract defaultRangeValue: (TimeSpan * TimeSpan) option
        abstract isRange : bool
        abstract displayMode : DisplayMode
        abstract clearLabel : string

    let private safeHours (hrs:int) =
        if hrs < 0 then 23
        else if hrs > 23 then 0
        else hrs

    let private safeMinutes (mins:int) =
        if mins < 0 then 59
        else if mins > 59 then 0
        else mins

    [<ReactComponent>]
    let internal timePickerValue (cn:string) (fixFn:int -> int) (count:int) (onDataChanged:int -> unit) =
        let increase _ =
            let newVal = (count + 1) |> fixFn
            newVal |> onDataChanged

        let decrease _ =
            let newVal = (count - 1) |> fixFn
            newVal |> onDataChanged

        Html.div [
            prop.className cn
            prop.children [
                Html.span [
                    prop.className "timepicker-next"
                    prop.text "+"
                    prop.onClick increase
                ]
                Html.divClassed "timepicker-input" [
                    Html.input [
                        prop.type' "number"
                    ]
                    Html.div [
                        prop.className "timepicker-input-number"
                        prop.text (sprintf "%02d" count)
                    ]
                ]
                Html.span [
                    prop.className "timepicker-previous"
                    prop.text "-"
                    prop.onClick decrease
                ]

            ]
        ]

    let internal timePickerHours (defVal:int) (onDataChanged:int -> unit) = timePickerValue "timepicker-hours" safeHours defVal onDataChanged

    let internal timePickerMinutes (defVal:int) (onDataChanged:int -> unit) = timePickerValue "timepicker-minutes" safeMinutes defVal onDataChanged

    let internal toTimeSpans (hs,ms,he,me) =
        TimeSpan.FromHours(float hs).Add(TimeSpan.FromMinutes(float ms)), TimeSpan.FromHours(float he).Add(TimeSpan.FromMinutes(float me))
    let internal toHrsMins (ts:TimeSpan,te:TimeSpan) = ts.Hours, ts.Minutes, te.Hours, te.Minutes
    let internal toFormattedTime (s:TimeSpan) = sprintf "%02d:%02d" s.Hours s.Minutes

    [<ReactComponent>]
    let timePicker (p:Props) =
        let myRef = React.useElementRef()

        let defaultValue =
            if p.isRange then p.defaultRangeValue
            else (p.defaultValue |> Option.map (fun x -> x, x))

        let time, setTime = React.useState(defaultValue)
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

        Hook.useOnClickOutside(myRef, fun _ -> setIsDisplayed false)

        let updateTime (t:(TimeSpan * TimeSpan) option) =
            t |> setTime
            if p.isRange && p.onTimeRangeSelected.IsSome then t |> p.onTimeRangeSelected.Value
            if not p.isRange && p.onTimeSelected.IsSome then t |> Option.map fst |> p.onTimeSelected.Value

        let safeTime =
            time
            |> Option.defaultValue (TimeSpan.Zero, TimeSpan.Zero)

        let sh,sm,eh,em = safeTime |> toHrsMins

        let updateHoursStart (i:int) = (i,sm,eh,em) |> toTimeSpans |> Some |> updateTime
        let updateMinutesStart (i:int) = (sh,i,eh,em) |> toTimeSpans |> Some |> updateTime
        let updateHoursEnd (i:int) = (sh,sm,i,em) |> toTimeSpans |> Some |> updateTime
        let updateMinutesEnd (i:int) = (sh,sm,eh,i) |> toTimeSpans |> Some |> updateTime

        let body  = [
            Html.divClassed "datetimepicker-container" [
                Html.divClassed "timepicker" [
                    Html.divClassed "timepicker-start" [
                        timePickerHours sh updateHoursStart
                        Html.divClassed "timepicker-time-divider" [ Html.text ":" ]
                        timePickerMinutes sm updateMinutesStart
                    ]
                    if p.isRange then
                        Html.divClassed "timepicker-end" [
                            timePickerHours eh updateHoursEnd
                            Html.divClassed "timepicker-time-divider" [ Html.text ":" ]
                            timePickerMinutes em updateMinutesEnd
                        ]
                ]
            ]
            Html.divClassed "datetimepicker-footer" [
                Html.button [
                    prop.classes [ "datetimepicker-footer-clear"; "has-text-danger"; "button"; "is-small"; "is-text" ]
                    prop.type' "button"
                    prop.text p.clearLabel
                    prop.onClick (fun _ -> None |> updateTime)
                ]
            ]
        ]
        let txtValue =
            if p.isRange then time |> Option.map (fun (s,t) -> sprintf "%s - %s" (toFormattedTime s) (toFormattedTime t))
            else time |> Option.map fst |> Option.map toFormattedTime
            |> Option.defaultValue ""

        let input =
            match p.displayMode with
            | DisplayMode.Default ->
                Bulma.control.div [
                    control.hasIconsLeft
                    prop.children [
                        Bulma.input.text [
                            prop.readOnly true
                            prop.valueOrDefault txtValue
                            prop.onClick (fun _ -> setIsDisplayed true)
                        ]
                        Bulma.icon [
                            prop.style [ style.zIndex 0 ]
                            icon.isLeft
                            prop.children [ Html.i [ prop.className "far fa-clock" ++ color.hasTextGrey ] ]
                        ]
                    ]
                ]

            | DisplayMode.Inline -> Html.none

        Html.div [
            input
            body |> Layout.wrapper isDisplayed p.displayMode myRef
        ]

type ITimePickerProperty = interface end

[<Erase>]
type timePicker =
    static member inline onTimeSelected (eventHandler: TimeSpan option -> unit) : ITimePickerProperty = unbox ("onTimeSelected", eventHandler)
    static member inline onTimeRangeSelected (eventHandler: (TimeSpan * TimeSpan) option -> unit) : ITimePickerProperty = unbox ("onTimeRangeSelected", eventHandler)
    static member inline onShow (eventHandler: unit -> unit) : ITimePickerProperty = unbox ("onShow", eventHandler)
    static member inline onHide (eventHandler: unit -> unit) : ITimePickerProperty = unbox ("onHide", eventHandler)
    static member inline defaultValue (v:TimeSpan) : ITimePickerProperty = unbox ("defaultValue", v)
    static member inline defaultRangeValue (v:(TimeSpan * TimeSpan)) : ITimePickerProperty = unbox ("defaultRangeValue", v)
    static member inline isRange (v:bool) : ITimePickerProperty = unbox ("isRange", v)
    static member inline displayMode (v:DisplayMode) : ITimePickerProperty = unbox ("displayMode", v)
    static member inline clearLabel (v:string) : ITimePickerProperty = unbox ("clearLabel", v)
