module Docs.Views.QuickView

open Feliz
open Feliz.Bulma
open Feliz.Bulma.QuickView
open Shared
open Docs.Domain

let overview model dispatch =
    let qv =
        QuickView.quickview [
            if model.ShowQuickView then yield quickview.isActive
            yield prop.children [
                QuickView.header [
                    Html.div "Header"
                    Bulma.delete [ prop.onClick (fun _ -> ToggleQuickView |> dispatch) ]
                ]
                QuickView.body [
                    QuickView.block "Bulma is great"
                ]
                QuickView.footer [
                    Bulma.button.a "Save"
                ]
            ]
        ]

    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.Bulma.QuickView "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.QuickView/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.QuickView.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h3 [
            Html.a [ prop.href "https://wikiki.github.io/components/quickview/"; prop.text "QuickView" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding QuickView component"
            code """open Feliz.Bulma.QuickView

QuickView.quickview [
    if model.ShowQuickView then yield quickview.isActive
    yield prop.children [
        QuickView.header [
            Html.div "Header"
            Bulma.delete [ prop.onClick (fun _ -> ToggleQuickView |> dispatch) ]
        ]
        QuickView.body [
            QuickView.block "Bulma is great"
        ]
        QuickView.footer [
            Bulma.button "Save"
        ]
    ]
]"""
            Bulma.button.a [
                color.isInfo
                prop.text (if model.ShowQuickView then "Hide QuickView" else "Show QuickView")
                prop.onClick (fun _ -> ToggleQuickView |> dispatch)
            ]
            qv
        ]
    ]

let installation = Shared.installationView "Feliz.Bulma.QuickView" "bulma-quickview"
