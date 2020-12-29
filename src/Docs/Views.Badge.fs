module Docs.Views.Badge

open Feliz
open Feliz.Bulma
open Shared

let description =
    Html.div [
        Bulma.content [
            Bulma.title.h5 "Basic badge"
            code """open Feliz.Bulma

Bulma.button.button [
    Badge.badge [
        badge.title "Hello"
        badge.value 42
    ]
    Html.text "Button with badge"
]
"""

            Html.p "Code above will generate a nice button with badge:"

            Bulma.button.button [
                Badge.badge [
                    badge.title "Hello"
                    badge.value 42
                ]
                Html.text "Button with badge"
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Outlined badge"
            Html.p "The badge is available in outlined style:"
            code """Bulma.button.button [
    Badge.badge [
        badge.title "Hello"
        badge.value 42
        badge.isOutlined
    ]
    Html.text "Button with outlined badge"
]
"""
            Bulma.button.button [
                Badge.badge [
                    badge.title "Hello"
                    badge.value 42
                    badge.isOutlined
                ]
                Html.text "Button with outlined badge"
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Colored badge"
            Html.p "Colors, colors everywhere!"
            code """Bulma.buttons [
    Bulma.button.button [ Badge.badge [ badge.value "42"; color.isPrimary ]; Html.text "Primary" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; color.isDanger ]; Html.text "Danger" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; color.isSuccess ]; Html.text "Success" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; color.isWarning ]; Html.text "Warning" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; color.isInfo ]; Html.text "Info" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; color.isDark ]; Html.text "Dark" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; color.isLight ]; Html.text "Light" ]
]
"""
            Bulma.buttons [
                Bulma.button.button [ Badge.badge [ badge.value "42"; color.isPrimary ]; Html.text "Primary" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; color.isDanger ]; Html.text "Danger" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; color.isSuccess ]; Html.text "Success" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; color.isWarning ]; Html.text "Warning" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; color.isInfo ]; Html.text "Info" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; color.isDark ]; Html.text "Dark" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; color.isLight ]; Html.text "Light" ]
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Positioned badge"
            Html.p "Top, bottom - your call!"
            code """Bulma.buttons [
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isTopLeft ]; Html.text "Top left" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isTop ]; Html.text "Top" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isTopRight ]; Html.text "Top right" ]
]
Bulma.buttons [
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isLeft ]; Html.text "Left" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isRight ]; Html.text "Right" ]
]
Bulma.buttons [
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isBottomLeft ]; Html.text "Bottom left" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isBottom ]; Html.text "Bottom" ]
    Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isBottomRight ]; Html.text "Bottom right" ]
]
"""
            Bulma.buttons [
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isTopLeft ]; Html.text "Top left" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isTop ]; Html.text "Top" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isTopRight ]; Html.text "Top right" ]
            ]
            Bulma.buttons [
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isLeft ]; Html.text "Left" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isRight ]; Html.text "Right" ]
            ]
            Bulma.buttons [
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isBottomLeft ]; Html.text "Bottom left" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isBottom ]; Html.text "Bottom" ]
                Bulma.button.button [ Badge.badge [ badge.value "42"; badge.isBottomRight ]; Html.text "Bottom right" ]
            ]
        ]
    ]

let view =
    ComponentView
        "Badge"
        "Feliz.Bulma.Badge"
        "https://bulma-badge.netlify.app/"
        description
        (installationView "Feliz.Bulma.Badge" "@creativebulma/bulma-badge" "@creativebulma/bulma-badge")
