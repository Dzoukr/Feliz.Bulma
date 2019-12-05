module Docs.Views.Tooltip

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Tooltip
open Shared
open Docs.Domain

let overview =
    Html.div [
        Bulma.title [
            Html.text "Feliz.Bulma.Tooltip "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.Tooltip/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Tooltip.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle [
            Html.a [ prop.href "https://wikiki.github.io/elements/tooltip/"; prop.text "Tooltip" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Tooltip component"
            code """open Feliz.Bulma.Tooltip
            
Bulma.button [
    tooltip.text "This is tooltip"
    tooltip.hasTooltipWarning
    prop.text "Hover me for tooltip"
]"""
            
            Html.p "Code above will add tooltip to button:"
            Bulma.button [
                tooltip.text "This is tooltip"
                tooltip.hasTooltipWarning
                prop.text "Hover me for tooltip"
            ]
            
        ]
    ]

let installation =
    Html.div [
        Bulma.title "Feliz.Bulma.Tooltip - Installation"
        Html.hr []
        Bulma.content [
            Bulma.title4 "Using Femto (recommended)"
            Html.p [ prop.dangerouslySetInnerHTML "The easiest way is to use <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> which will take care of all dependencies including npm libraries." ]
            code "femto install Feliz.Bulma.Tooltip"
        ]
        Bulma.content [
            Bulma.title4 "Manual"
            Html.p "If you want to install this package manually, use usual NuGet package command"
            code "Install-Package Feliz.Bulma.Tooltip"
            Html.p "or using Paket"
            code "paket add Feliz.Bulma.Tooltip"
            Html.p "Please don't forget that this library has also dependencies on frontend (css styles), so you need to add it to package.json file using yarn / npm command"
            code "yarn add bulma-tooltip"
        ]
    ]