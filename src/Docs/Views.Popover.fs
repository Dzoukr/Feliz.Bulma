module Docs.Views.Popover

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Popover
open Shared
open Docs.Domain

let overview =
    Html.div [
        Bulma.title [
            Html.text "Feliz.Bulma.Popover "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.Popover/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Popover.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle [
            Html.a [ prop.href "https://github.com/apnsngr/bulma-popover"; prop.text "Popover" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Popover component"
            code """open Feliz.Bulma.Popover
            
Popover.popover [
    Bulma.button [
        prop.text "Hover me for popover"
        button.isInfo
        popover.trigger
    ]
    Popover.content [
        Html.div "Wow so much popover content"
        Html.img [ prop.src "https://pbs.twimg.com/profile_images/518069764510330880/yRNL7yTW_200x200.png" ]
    ]
]"""
            
            Html.p "Code above will add popover to button:"
            Popover.popover [
                Bulma.button [
                    prop.text "Hover me for popover"
                    button.isInfo
                    popover.trigger
                ]
                Popover.content [
                    Html.div "Wow so much popover content"
                    Html.img [ prop.src "https://pbs.twimg.com/profile_images/518069764510330880/yRNL7yTW_200x200.png" ]
                ]
            ]
        ]
        Bulma.content [
            Html.p "Popover content can be positioned."
            code """open Feliz.Bulma.Popover

Popover.popover [
    popover.isRight
    prop.children [
        Bulma.button [
            prop.text "Hover me for popover"
            button.isInfo
            popover.trigger
        ]
        Popover.content [
            Html.div "I am always... right! (pun intended)"
        ]
    ]
]
"""
            Html.p "Code above will show popover on right side:"
            Popover.popover [
                popover.isRight
                prop.children [
                    Bulma.button [
                        prop.text "Hover me for popover"
                        button.isInfo
                        popover.trigger
                    ]
                    Popover.content [
                        Html.div "I am always... right! (pun intended)"
                    ]
                ]
            ]
        ]
        Bulma.content [
            Html.p "Popover can be made always active."
            code """open Feliz.Bulma.Popover

Popover.popover [
    popover.isActive
    popover.isBottom
    prop.children [
        Bulma.button [
            prop.text "No need to hover me"
            button.isInfo
            popover.trigger
        ]
        Popover.content [
            Html.div "I'll be here just forever"
            Html.img [ prop.src "https://media.giphy.com/media/EkDhogNB3yo3C/giphy.gif" ]
        ]
    ]
]
"""
            Popover.popover [
                popover.isActive
                popover.isBottom
                prop.children [
                    Bulma.button [
                        prop.text "No need to hover me"
                        button.isInfo
                        popover.trigger
                    ]
                    Popover.content [
                        Html.div "I'll be here just forever"
                        Html.img [ prop.src "https://media.giphy.com/media/EkDhogNB3yo3C/giphy.gif" ]
                    ]
                ]
            ]
        ]
    ]

let installation = Shared.installationView "Feliz.Bulma.Popover" "bulma-popover"