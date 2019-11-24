module Sandbox.View

open Domain
open Fable.Core
open Fable.React
open Feliz
open Feliz.Bulma
open Feliz.Bulma.Extensions.QuickView
open Feliz.Bulma.Extensions.Calendar
    
let view (model : Model) (dispatch : Msg -> unit) =
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
    
    
    Bulma.content [
        Calendar.calendar []
    ]
    
    