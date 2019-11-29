module Docs.State

open Domain
open Elmish
open Docs.Router

let init () = Model.init, Cmd.none

let update (msg : Msg) (currentModel : Model) : Model * Cmd<Msg> =
    match msg with
    | UrlChanged p -> { currentModel with CurrentPage = p }, Cmd.none
    | Nothing -> currentModel, Cmd.none