namespace Feliz.Bulma.Extensions.Calendar

open Fable.Core
open System
open Feliz

module Interop =
    let attachCalendar (x:string) (y:obj) (z:obj) : unit = JsInterop.import "attach" "./Calendar.js"

module internal Calendar = 
    let inline tryToDateTime (date:DateTime) (time:DateTime) =
        match box date, box time with
        | null, _ | _, null -> None
        | _, _ -> DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 0) |> Some
    
    let inline tryToDate (date:DateTime) =
        match box date with
        | null -> None
        | _ -> date.Date |> Some
    
    let inline toTime (time:DateTime) = { Hours = time.Hour; Minutes = time.Minute }
    
    let inline toParams (p:{|startDate:DateTime; endDate:DateTime; startTime:DateTime; endTime:DateTime; mode:string; isRange:bool|}) =
        if p.isRange then
            (match p.mode with
            | "date" -> (tryToDate p.startDate, tryToDate p.endDate) |> RangeValue.Date
            | "datetime" -> ((tryToDateTime p.startDate p.startTime),(tryToDateTime p.endDate p.endTime)) |> RangeValue.DateTime
            | "time" -> ((p.startTime |> toTime),(p.endTime |> toTime)) |> RangeValue.Time  
            | v -> failwithf "Unrecognized Calendar component type '%s'" v)
            |> SelectedValue.Range
        else
            (match p.mode with
            | "date" -> p.startDate |> tryToDate |> SingleValue.Date
            | "datetime" -> tryToDateTime p.startDate p.startTime |> SingleValue.DateTime
            | "time" -> p.startTime |> toTime |> SingleValue.Time  
            | v -> failwithf "Unrecognized Calendar component type '%s'" v)
            |> SelectedValue.Single

module internal ParamsFinder =
    let inline tryFind name props =
        props
        |> List.map unbox<string * _>
        |> List.tryFind (fun (n,v) -> n = name)
        |> Option.map snd

type Calendar =
    static member inline calendar (props:IReactProperty list) =
        let id =
            ParamsFinder.tryFind "id" props
            |> Option.map string
            |> Option.defaultValue "default"
        
        let onValueSelectedHandler =
            ParamsFinder.tryFind "onValueSelected" props
            |> Option.defaultValue ignore
        
        let options =
            ParamsFinder.tryFind "calendarOptions" props
            |> Option.defaultValue []
            |> JsInterop.keyValueList CaseRules.None
            
        Html.input [
            prop.type'.date
            prop.id id
            prop.ref (fun elm ->
                if not (isNull elm) then
                    Interop.attachCalendar id (Calendar.toParams >> onValueSelectedHandler) options
            )
        ]