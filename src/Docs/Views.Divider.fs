module Docs.Views.Divider

open Feliz
open Feliz.Bulma
open Shared

let description =
    Html.div
        [
          Bulma.content [

            Bulma.title.h5 "Basic divider"
            code """open Feliz.Bulma

Divider.divider "example"""

            Html.p "Code above will generate a nice switch:"
            Divider.divider "example"

            Bulma.title.h5 "Vertical divider"
            Html.p "If you need, you can align divider in vertical position:"
            code """Html.div [
    prop.style [ style.display.flex ]
    prop.children [
        Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
        Divider.divider [
            divider.isVertical
            divider.text "vertical"
        ]
        Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
    ]
]"""
            Html.div [
                prop.style [ style.display.flex ]
                prop.children [
                    Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
                    Divider.divider [ divider.isVertical; divider.text "vertical" ]
                    Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
                ]
            ]

            Html.p ""
            Bulma.title.h5 "Colorized divider"
            Html.p "But what would divider be without some fancy color, right?"
            code """Divider.divider [ divider.text "Info"; color.isInfo ]
Divider.divider [ divider.text "Success"; color.isSuccess ]
Divider.divider [ divider.text "Warning"; color.isWarning ]
Divider.divider [ divider.text "Danger"; color.isDanger ]
Divider.divider [ divider.text "Primary"; color.isPrimary ]
"""
            Divider.divider [ divider.text "Info"; color.isInfo ]
            Divider.divider [ divider.text "Success"; color.isSuccess ]
            Divider.divider [ divider.text "Warning"; color.isWarning ]
            Divider.divider [ divider.text "Danger"; color.isDanger ]
            Divider.divider [ divider.text "Primary"; color.isPrimary ]

            Bulma.title.h5 "Aligned divider"
            Html.p "Align me softly..."
            code """Divider.divider [ divider.text "Left"; divider.isLeft ]
Divider.divider [ divider.text "Right"; divider.isRight ]
"""
            Divider.divider [ divider.text "Left"; divider.isLeft ]
            Divider.divider [ divider.text "Right"; divider.isRight ]

            Bulma.title.h5 "Vertically aligned"
            code """Html.div [
    prop.style [ style.display.flex ]
    prop.children [
        Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
        Divider.divider [ divider.isVertical; divider.isLeft; divider.text "top" ]
        Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
    ]
]"""
            Html.div [
                prop.style [ style.display.flex ]
                prop.children [
                    Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
                    Divider.divider [ divider.isVertical; divider.isLeft; divider.text "left is top" ]
                    Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
                ]
            ]

            Html.p ""
            code """Html.div [
    prop.style [ style.display.flex ]
    prop.children [
        Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
        Divider.divider [ divider.isVertical; divider.isRight; divider.text "right is bottom" ]
        Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
    ]
]
"""
            Html.div [
                prop.style [ style.display.flex ]
                prop.children [
                    Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
                    Divider.divider [ divider.isVertical; divider.isRight; divider.text "right is bottom" ]
                    Html.div [ prop.style [ style.height 200; style.flexGrow 1; style.backgroundColor "#f4f5f8" ] ]
                ]
            ]
        ]
    ]

let view =
    ComponentView
        "Divider"
        "Feliz.Bulma.Divider"
        "https://bulma-divider.netlify.app/"
        description
        (installationView "Feliz.Bulma.Divider" "@creativebulma/bulma-divider" "@creativebulma/bulma-divider")
