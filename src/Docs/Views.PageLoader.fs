module Docs.Views.PageLoader

open Feliz
open Feliz.Bulma
open Feliz.Bulma.PageLoader
open Shared
open Docs.Domain
open Docs.Views

let overview (model:Model) dispatch =
    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.Bulma.PageLoader "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.PageLoader/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.PageLoader.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h2 [
            Html.a [ prop.href "https://wikiki.github.io/elements/pageloader/"; prop.text "Page Loader" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Page Loader component"
            code """open Feliz.Bulma.PageLoader

PageLoader.pageLoader [
    pageLoader.isSuccess
    if model.ShowLoader then pageLoader.isActive
    prop.children [
        PageLoader.title "I am loading some awesomeness"
    ]
]

Bulma.button [
    button.isSuccess
    prop.text "Show page loader for 2 seconds"
    prop.onClick (fun _ -> ToggleLoader |> dispatch)
]"""

            Html.p "Code above will setup Page Loader:"
            PageLoader.pageLoader [
                pageLoader.isSuccess
                if model.ShowLoader then pageLoader.isActive
                prop.children [
                    PageLoader.title "I am loading some awesomeness"
                ]
            ]

            Bulma.button.a [
                color.isSuccess
                prop.text "Show page loader for 2 seconds"
                prop.onClick (fun _ -> ToggleLoader |> dispatch)
            ]

        ]
    ]

let installation = Shared.installationView "Feliz.Bulma.PageLoader" "bulma-pageloader"