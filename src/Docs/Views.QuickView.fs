module Docs.Views.QuickView

open Feliz
open Feliz.Bulma
open Shared

[<ReactComponent>]
let Description () =
    let isShown,show = React.useState(false)
    let qv =
        QuickView.quickview [
            if isShown then quickview.isActive
            prop.children [
                QuickView.header [
                    Html.div "Header"
                    Bulma.delete [ prop.onClick (fun _ -> show(false)) ]
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
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding QuickView component"
            code """open Feliz.Bulma

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
                prop.text (if isShown then "Hide QuickView" else "Show QuickView")
                prop.onClick (fun _ -> show(not isShown))
            ]
            qv
        ]
    ]

let view =
    ComponentView
        "QuickView"
        "Feliz.Bulma.QuickView"
        "https://wikiki.github.io/components/quickview/"
        (Description())
        (installationView "Feliz.Bulma.QuickView" "bulma-quickview" "bulma-quickview")
