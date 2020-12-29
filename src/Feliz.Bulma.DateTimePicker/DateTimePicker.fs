namespace Feliz.Bulma

open Fable.Core
open Fable.Core.JsInterop

module private Props =
    let inline setDefault<'a> (name:string, value:obj) (props:List<'a>) =
        let found =
            props
            |> List.map unbox<string * _>
            |> List.exists (fun (n,_) -> n = name)
        match found with
        | true -> props
        | false -> (unbox (name, value)) :: props

[<Erase>]
type DateTimePicker =
    static member inline timePicker (props: ITimePickerProperty list) =
        let safeProps =
            props
            |> Props.setDefault ("displayMode", DisplayMode.Default)
            |> Props.setDefault ("clearLabel", "Clear")
        TimePicker.timePicker (unbox<TimePicker.Props> (createObj !!safeProps))

    static member inline dateTimePicker (props: IDateTimePickerProperty list) =
        let safeProps =
            props
            |> Props.setDefault ("displayMode", DisplayMode.Default)
            |> Props.setDefault ("clearLabel", "Clear")
        DatePicker.dateTimePicker (unbox<DatePicker.Props> (createObj !!safeProps))
