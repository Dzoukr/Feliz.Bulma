module Sandbox.View

open Domain
open Fable.Core
open Fable.React
open Feliz
open Feliz.Bulma
    
let view (model : Model) (dispatch : Msg -> unit) =
    Bulma.section [
        Bulma.message [
            Bulma.messageBody "AHOJ"
        ]
    ]