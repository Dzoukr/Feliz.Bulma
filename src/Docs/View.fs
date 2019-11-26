module Docs.View

open System
open System
open Domain
open Fable.Core
open Fable.React
open Feliz
open Feliz.Bulma
open Feliz.Bulma
open Feliz.Bulma.Extensions.QuickView
open Feliz.Bulma.Extensions.Calendar
    
let view (model : Model) (dispatch : Msg -> unit) =
    Bulma.section [
        Bulma.hero [
            Bulma.title "Feliz.Bulma |> Hello"
        ]
    ]

//    QuickView.quickview [
//        prop.className "is-active"
//        prop.children [
//            QuickView.header [
//                Html.div "AHOJ"
//            ]
//            QuickView.body [
//                QuickView.block "AAA"
//                QuickView.block "BBB"
//            ]
//            QuickView.footer [
//                Bulma.button "CLICK"
//            ]
//        ]
//    ]
    
        
//    Bulma.content [
//        
//        Bulma.field [
//            Bulma.fieldLabel "TEST"
//            Bulma.fieldBody [
//                
//                Calendar.calendar [
//                    prop.id "MOJE"
//                    calendar.options [
//                        calendar.options.type'.datetime
//                        calendar.options.isRange true
//                        
//                        calendar.options.disabledDates [
//                            DateTime.Now
//                        ]
//                    ]
//                    calendar.onValueSelected (fun x ->
//                        Fable.Core.JS.console.log(x)
//                    )
//                    
//                ]
//                Bulma.button [
//                    prop.onClick (fun _ -> Nothing |> dispatch)
//                    prop.text "POME"
//                ]
//            ]
//        ]
//        
//    ]
    
    
    