module Docs.Views.Tooltip

open Feliz
open Feliz.Bulma
open Shared

let description =
    Html.div [
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Tooltip component"
            code """open Feliz.Bulma

Bulma.button.a [
    tooltip.text "This is tooltip"
    tooltip.hasTooltipWarning
    color.isWarning
    prop.text "Hover me for tooltip"
]"""

            Html.p "Code above will add tooltip to button:"
            Bulma.button.a [
                tooltip.text "This is tooltip"
                tooltip.hasTooltipWarning
                color.isWarning
                prop.text "Hover me for tooltip"
            ]

        ]
    ]

let view =
    ComponentView
        "Tooltip"
        "Feliz.Bulma.Tooltip"
        "https://wikiki.github.io/elements/tooltip/"
        description
        (installationView "Feliz.Bulma.Tooltip" "bulma-tooltip" "bulma-tooltip")

