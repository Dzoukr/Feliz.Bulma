module Docs.Domain

type Model = {
    CurrentPage : Router.Page
}

module Model =
    let init = {
        CurrentPage = Router.defaultPage
    }

type Msg =
    | UrlChanged of Router.Page
    | Nothing