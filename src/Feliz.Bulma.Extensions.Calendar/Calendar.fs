namespace Feliz.Bulma.Extensions.Calendar

open Browser
open Fable.Core
open Fable.React.ReactiveComponents
open System
open Feliz
open Feliz
open Feliz.Bulma

type Pars = {
    startDate : DateTimeOffset
    endDate : DateTimeOffset option
    startTime : string
    endTime : string
}

module Calendar = 
    let attach (x:string) (y:obj) : unit =  JsInterop.import "attach" "./custom.js"

type Calendar =
    static member inline calendar (props:IReactProperty list) =
        let id =
            props
            |> List.map unbox<string * _>
            |> List.tryFind (fun (n,v) -> n = "id")
            |> Option.map (snd >> string)
            |> Option.defaultValue "default"
        
        let handler =
            props
            |> List.map unbox<string * _>
            |> List.tryFind (fun (n,v) -> n = "onDateSelected")
            |> Option.map snd
            |> Option.defaultValue (fun _ -> ())
        
                    
        let doSomething = fun (p:Pars) ->
            Fable.Core.JS.console.log("FROM F#")            
            Fable.Core.JS.console.log(p.startDate)            
            
        Html.input [
            prop.type'.date
            prop.id id
            prop.ref (fun elm ->
                if not (isNull elm) then
                    Calendar.attach id doSomething
            )
            
        ]