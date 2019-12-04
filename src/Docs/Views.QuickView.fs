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
                    Bulma.button "Save"
                ]
            ]
        ]
    
    Html.div [
        Bulma.title [
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
        Bulma.subtitle [
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
            Bulma.button [
                button.isInfo
                prop.text (if model.ShowQuickView then "Hide QuickView" else "Show QuickView")
                prop.onClick (fun _ -> ToggleQuickView |> dispatch)
            ]
            qv
        ]
    ]

let installation =
    Html.div [
        Bulma.title "Feliz.Bulma.QuickView - Installation"
        Html.hr []
        Bulma.content [
            Bulma.title4 "Using Femto (recommended)"
            Html.p [ prop.dangerouslySetInnerHTML "The easiest way is to use <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> which will take care of all dependencies including npm libraries." ]
            code "femto install Feliz.Bulma.QuickView"
        ]
        Bulma.content [
            Bulma.title4 "Manual"
            Html.p "If you want to install this package manually, use usual NuGet package command"
            code "Install-Package Feliz.Bulma.QuickView"
            Html.p "or using Paket"
            code "paket add Feliz.Feliz.Bulma.QuickView"
            Html.p "Please don't forget that this library has also dependencies on frontend (css styles), so you need to add it to package.json file using yarn / npm command"
            code "yarn add bulma-quickview"
        ]
    ]