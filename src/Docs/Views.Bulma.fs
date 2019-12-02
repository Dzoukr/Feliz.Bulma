module Docs.Views.Bulma

open Feliz
open Feliz.Bulma
open Shared

let overview =
    Html.div [
        Bulma.title [
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
        Bulma.subtitle [
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
            Bulma.title4 "Features"
            Html.ul [
                Html.li "Fully compatible with Feliz DSL syntax"
                Html.li "100% API coverage of Bulma UI (v0.8.0)"
                Html.li [ prop.dangerouslySetInnerHTML "Compatible with <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> "]
                
            ]
        ]
    ]
    
let installation =
    Html.div [
        Bulma.title "Feliz.Bulma - Installation"
        Html.hr []
        Bulma.content [
            Bulma.title4 "Using Femto (recommended)"
            Html.p [ prop.dangerouslySetInnerHTML "The easiest way is to use <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> which will take care of all dependencies including npm libraries." ]
            code "femto install Feliz.Bulma"
        ]
        Bulma.content [
            Bulma.title4 "Manual"
            Html.p "If you want to install this package manually, use usual NuGet package command"
            code "Install-Package Feliz.Bulma"
            Html.p "or using Paket"
            code "paket add Feliz.Bulma"
            Html.p "Please don't forget that this library has also dependencies on frontend (css styles), so you need to add it to package.json file using yarn / npm command"
            code "yarn add bulma"
        ]
    ]
    
let apiDescription =
    Html.div [
        Bulma.title "Feliz.Bulma - API"
        Html.hr []
        Bulma.content [
            Html.p [ prop.dangerouslySetInnerHTML "Feliz.Bulma fully covers <a href='https://bulma.io'>Bulma UI</a> in version 0.8.0." ]
        ]
        Bulma.content [
            Bulma.title4 "Example"
            code """open Feliz.Bulma
            
Bulma.button [
    button.isWarning
    prop.onClick (fun _ -> Fable.Core.JS.eval "alert('Hello Feliz.Bulma')" |> ignore)
    prop.text "Amazing button, ain't it?"
]
"""
            Html.p "will generate this button"
            Bulma.button [
                button.isWarning
                prop.onClick (fun _ -> Fable.Core.JS.eval "alert('Hello Feliz.Bulma')" |> ignore)
                prop.text "Amazing button, ain't it?"
            ]
        ]
        Bulma.content [
            Html.p [ prop.dangerouslySetInnerHTML "API was designed to be more less 1:1 with Bulma. To see what elements are available in Feliz.Bulma, please check <a href='https://bulma.io/documentation/'>official Bulma documentation</a>." ]
        ]
    ]