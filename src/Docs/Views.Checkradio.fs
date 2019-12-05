module Docs.Views.Checkradio

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Checkradio
open Shared
open Docs.Domain

let overview =
    Html.div [
        Bulma.title [
            Html.text "Feliz.Bulma.Checkradio "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.Checkradio/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Checkradio.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle [
            Html.a [ prop.href "https://wikiki.github.io/form/checkradio/"; prop.text "Checkradio" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Checkradio component"
            code """open Feliz.Bulma.Checkradio
            
Bulma.field [
    Checkradio.checkbox [
        prop.id "mycheck"
        color.isDanger
    ]
    Html.label [
        prop.htmlFor "mycheck"
        prop.text "Check me"
    ]
]"""
            
            Html.p "Code above will generate a nice checkbox:"
            Bulma.field [
                Checkradio.checkbox [
                    prop.id "mycheck"
                    color.isDanger
                ]
                Html.label [
                    prop.htmlFor "mycheck"
                    prop.text "Check me"
                ]
            ]
        ]
        Bulma.content [
            code """open Feliz.Bulma.Checkradio
            
Bulma.field [
    Checkradio.radio [ prop.id "myradio1"; prop.name "radio" ]
    Html.label [ prop.htmlFor "myradio1"; prop.text "Option one" ]
    Checkradio.radio [ prop.id "myradio2"; prop.name "radio" ]
    Html.label [ prop.htmlFor "myradio2"; prop.text "Option two" ]
]
"""
            Html.p "Code above will generate a nice two radio buttons:"
            Bulma.field [
                Checkradio.radio [ prop.id "myradio1"; prop.name "radio" ]
                Html.label [ prop.htmlFor "myradio1"; prop.text "Option one" ]
                Checkradio.radio [ prop.id "myradio2"; prop.name "radio" ]
                Html.label [ prop.htmlFor "myradio2"; prop.text "Option two" ]
            ]
            
        ]
        Bulma.content [
            Html.p [ prop.dangerouslySetInnerHTML "All the modifiers mentioned in <a href='https://wikiki.github.io/form/checkradio/'>official documentation</a> will work as expected." ]
            code """open Feliz.Bulma.Checkradio
            
Bulma.field [
    Checkradio.checkbox [
        prop.id "bigcheck"
        color.isSuccess
        checkradio.isCircle
        checkradio.isLarge
        checkradio.hasBackgroundColor
    ]
    Html.label [
        prop.htmlFor "bigcheck"
        prop.text "Large round success checkbox"
    ]
]                        
"""
            Bulma.field [
                Checkradio.checkbox [
                    prop.id "bigcheck"
                    color.isSuccess
                    checkradio.isCircle
                    checkradio.isLarge
                    checkradio.hasBackgroundColor
                ]
                Html.label [
                    prop.htmlFor "bigcheck"
                    prop.text "Large round success checkbox"
                ]
            ]
        ]
    ]

let installation =
    Html.div [
        Bulma.title "Feliz.Bulma.Checkradio - Installation"
        Html.hr []
        Bulma.content [
            Bulma.title4 "Using Femto (recommended)"
            Html.p [ prop.dangerouslySetInnerHTML "The easiest way is to use <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> which will take care of all dependencies including npm libraries." ]
            code "femto install Feliz.Bulma.Checkradio"
        ]
        Bulma.content [
            Bulma.title4 "Manual"
            Html.p "If you want to install this package manually, use usual NuGet package command"
            code "Install-Package Feliz.Bulma.Checkradio"
            Html.p "or using Paket"
            code "paket add Feliz.Bulma.Checkradio"
            Html.p "Please don't forget that this library has also dependencies on frontend (css styles), so you need to add it to package.json file using yarn / npm command"
            code "yarn add bulma-checkradio"
        ]
    ]