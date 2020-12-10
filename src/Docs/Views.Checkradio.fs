module Docs.Views.Checkradio

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Checkradio
open Shared

let overview =
    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.Bulma.Checkradio "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.Checkradio/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Checkradio.svg?style=flat-square"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h3 [
            Html.a [ prop.href "https://wikiki.github.io/form/checkradio/"; prop.text "Checkradio" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Checkradio component"
            code """open Feliz.Bulma.Checkradio

Bulma.field.div [
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
            Bulma.field.div [
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

Bulma.field.div [
    Checkradio.radio [ prop.id "myradio1"; prop.name "radio" ]
    Html.label [ prop.htmlFor "myradio1"; prop.text "Option one" ]
    Checkradio.radio [ prop.id "myradio2"; prop.name "radio" ]
    Html.label [ prop.htmlFor "myradio2"; prop.text "Option two" ]
]
"""
            Html.p "Code above will generate a nice two radio buttons:"
            Bulma.field.div [
                Checkradio.radio [ prop.id "myradio1"; prop.name "radio" ]
                Html.label [ prop.htmlFor "myradio1"; prop.text "Option one" ]
                Checkradio.radio [ prop.id "myradio2"; prop.name "radio" ]
                Html.label [ prop.htmlFor "myradio2"; prop.text "Option two" ]
            ]

        ]
        Bulma.content [
            Html.p [ prop.dangerouslySetInnerHTML "All the modifiers mentioned in <a href='https://wikiki.github.io/form/checkradio/'>official documentation</a> will work as expected." ]
            code """open Feliz.Bulma.Checkradio

Bulma.field.div [
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
            Bulma.field.div [
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

let installation = Shared.installationView "Feliz.Bulma.Checkradio" "bulma-checkradio" "bulma-checkradio"
