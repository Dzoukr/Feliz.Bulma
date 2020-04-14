module Docs.Views.Bulma

open Feliz
open Feliz.Bulma
open Shared
open Feliz.Bulma.Operators

let overview =
    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.Bulma "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h2 [
            Html.text "Bulma UI wrapper for amazing "
            Html.a [ prop.href "https://github.com/Zaid-Ajaj/Feliz"; prop.text "Feliz DSL" ]
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library brings Bulma UI elements into Zaid Ajaj's Feliz library. Instead of writing:"
            code """Html.div [
    prop.className "columns"
    prop.children [
        Html.div [
            prop.className "column is-2"
            prop.children [
                Html.button [
                    prop.className "button"
                    prop.text "Click me"
                ]
            ]
        ]
    ]
]
"""
            Html.p "You just simply write:"
            code """open Feliz.Bulma

Bulma.columns [
    Bulma.column [
        column.is2 // <-- note context helper here
        prop.children [
            Bulma.button "Click me"
        ]
    ]
]
"""
        ]
        Bulma.content [
            Bulma.title.h4 "Features"
            Html.ul [
                Html.li "Fully compatible with Feliz DSL syntax"
                Html.li "100% API coverage of Bulma UI (v0.8.0)"
                Html.li [ prop.dangerouslySetInnerHTML "Compatible with <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> "]

            ]
        ]
    ]

let installation = Shared.installationView "Feliz.Bulma" "bulma"

let apiDescription =
    Html.div [
        Bulma.title.h1 "Feliz.Bulma - API"
        Html.hr []
        Bulma.content [
            Html.p [ prop.dangerouslySetInnerHTML "Feliz.Bulma fully covers <a href='https://bulma.io'>Bulma UI</a> in version 0.8.0." ]
        ]
        Bulma.content [
            Bulma.title.h4 "Example"
            code """open Feliz.Bulma

Bulma.button [
    button.isWarning
    prop.onClick (fun _ -> Fable.Core.JS.eval "alert('Hello Feliz.Bulma')" |> ignore)
    prop.text "Amazing button, ain't it?"
]
"""
            Html.p "Code above will generate this button:"
            Bulma.button.a [
                button.isWarning
                prop.onClick (fun _ -> Fable.Core.JS.eval "alert('Hello Feliz.Bulma')" |> ignore)
                prop.text "Amazing button, ain't it?"
            ]
        ]
        Bulma.content [
            Html.p [ prop.dangerouslySetInnerHTML "API was designed to be more less 1:1 with Bulma. To see what elements are available in Feliz.Bulma, please check <a href='https://bulma.io/documentation/'>official Bulma documentation</a>." ]
        ]

        Bulma.content [
            Bulma.title.h1 "Using Bulma props in Feliz elements"
            Html.p [ prop.dangerouslySetInnerHTML "Feliz.Bulma contains some helpers that could be handy to combine with <i>classic</i> Feliz API. Unfortunately this is not supported out of the box - <a href='https://github.com/Zaid-Ajaj/Feliz/issues/128'>see this issue.</a>"]
            Html.p [ prop.dangerouslySetInnerHTML "To allow this behavior, there is new <code>Feliz.Bulma.Operators</code> module with <code>++</code> operator" ]
            code """open Feliz.Bulma.Operators

Html.p [
    text.isUppercase
    ++ text.isItalic
    ++ color.hasTextSuccess
    prop.text "Hello Feliz"
]
"""

            Html.p "Code above will work as expected:"
            Html.p [
                text.isUppercase
                ++ text.isItalic
                ++ color.hasTextSuccess
                prop.text "Hello Feliz"
            ]
        ]
    ]