module Sandbox.View

open Domain
open Fable.Core
open Fable.React
open Feliz
open Feliz.Bulma
open Feliz.Bulma.Extensions
    
let view (model : Model) (dispatch : Msg -> unit) =
    QuickView.quickview [
        //prop.className "is-active"
        prop.children [
            QuickView.quickviewHeader [
                Html.div "AHOJ"
            ]
            QuickView.quickviewBody [
                QuickView.quickviewBlock "AAA"
                QuickView.quickviewBlock "BBB"
            ]
            QuickView.quickviewFooter [
                Bulma.button "CLICK"
            ]
        ]
    ]
    
    