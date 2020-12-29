module Docs.Views.Checkradio

open Feliz
open Feliz.Bulma
open Shared

let description =
    Html.div [
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Checkradio component"
            code """open Feliz.Bulma

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
            code """open Feliz.Bulma

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
            code """open Feliz.Bulma

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

let view =
    ComponentView
        "Checkradio"
        "Feliz.Bulma.Checkradio"
        "https://wikiki.github.io/form/checkradio/"
        description
        (installationView "Feliz.Bulma.Checkradio" "bulma-checkradio" "bulma-checkradio")
