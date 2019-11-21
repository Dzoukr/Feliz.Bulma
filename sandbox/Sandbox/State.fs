module Sandbox.State

open Domain
open Elmish

let init () : Model * Cmd<Msg> = "", Cmd.none

let update (msg : Msg) (currentModel : Model) : Model * Cmd<Msg> =
    match msg with
    | Nothing -> currentModel, Cmd.none