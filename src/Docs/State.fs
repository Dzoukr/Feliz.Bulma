module Docs.State

open Elmish
open Feliz.Router

type Model = {
    CurrentPage : Router.Page
}

module Model =
    let init = {
        CurrentPage = Router.defaultPage
    }

type Msg =
    | UrlChanged of Router.Page

let init () =
    let nextPage = (Router.currentUrl() |> Router.parseUrl)
    { Model.init with CurrentPage = nextPage }, Cmd.none

let update (msg : Msg) (currentModel : Model) : Model * Cmd<Msg> =
    match msg with
    | UrlChanged p -> { currentModel with CurrentPage = p }, Cmd.none
