module Docs.Views.Switch

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Switch
open Shared
open Docs.Domain

let overview =
    Html.div
        [ Bulma.title.h1
            [ Html.text "Feliz.Bulma.Switch "
              Html.a
                  [ prop.href "https://www.nuget.org/packages/Feliz.Bulma.Switch/"
                    prop.children
                        [ Html.img [ prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Switch.svg?style=flat-square" ] ] ] ]
          Bulma.subtitle.h3
              [ Html.a
                  [ prop.href "https://wikiki.github.io/form/switch/"
                    prop.text "Switch" ]
                Html.text " extension for Feliz.Bulma" ]
          Html.hr []
          Bulma.content
              [ Html.p "This library extends Feliz.Bulma by adding a Switch component"
                code """open Feliz.Bulma.Switch

Bulma.field [
    Switch.checkbox [
        prop.id "mycheck"
        color.isDanger
    ]
    Html.label [
        prop.htmlFor "mycheck"
        prop.text "Check me"
    ]
]"""

                Html.p "Code above will generate a nice switch:"
                Bulma.field.div
                    [ Switch.checkbox [ prop.id "mycheck"; color.isDanger ]
                      Html.label
                          [ prop.htmlFor "mycheck"
                            prop.text "Check me" ] ] ]
          Bulma.content
              [ code """open Feliz.Bulma.Switch

Bulma.field [
    Switch.checkbox [
        prop.id "bigcheck"
        color.isSuccess
        switch.isRounded
        switch.isLarge
    ]
    Html.label [
        prop.htmlFor "bigcheck"
        prop.text "Large round success checkbox"
    ]
]
"""
                Bulma.field.div
                    [ Switch.checkbox
                        [ prop.id "bigcheck"
                          color.isSuccess
                          switch.isRounded
                          switch.isLarge ]
                      Html.label
                          [ prop.htmlFor "bigcheck"
                            prop.text "Large round success checkbox" ] ] ]

          Bulma.content
              [ code """open Feliz.Bulma.Switch

Bulma.field [
    Switch.checkbox [
        prop.id "smallcheck"
        color.isWarning
        switch.isThin
        switch.isSmall
    ]
    Html.label [
        prop.htmlFor "smallcheck"
        prop.text "Small thin warning switch"
    ]
]
"""
                Bulma.field.div
                    [ Switch.checkbox
                        [ prop.id "smallcheck"
                          color.isWarning
                          switch.isThin
                          switch.isSmall ]
                      Html.label
                          [ prop.htmlFor "smallcheck"
                            prop.text "Small thin warning switch" ] ] ]

          Bulma.content
              [ code """open Feliz.Bulma.Switch

Bulma.field [
    Switch.checkbox [
        prop.id "mediumcheck"
        color.isInfo
        switch.isOutlined
        switch.isMedium
    ]
    Html.label [
        prop.htmlFor "mediumcheck"
        prop.text "Medium outlined info switch"
    ]
]
"""
                Bulma.field.div
                    [ Switch.checkbox
                        [ prop.id "mediumcheck"
                          color.isInfo
                          switch.isOutlined
                          switch.isMedium ]
                      Html.label
                          [ prop.htmlFor "mediumcheck"
                            prop.text "Medium outlined info switch" ] ] ] ]

let installation =
    Shared.installationView "Feliz.Bulma.Switch" "bulma-switch" "bulma-switch"
