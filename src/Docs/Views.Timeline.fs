module Docs.Views.Timeline

open Feliz
open Feliz.Bulma
open Shared

let description =
    Html.div [
        Bulma.content [
            Bulma.title.h5 "Basic timeline"
            code """open Feliz.Bulma

Timeline.timeline [
    Timeline.header [
        Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "Start" ]
    ]
    Timeline.item [
        Timeline.marker []
        Timeline.content [
            Timeline.content.header "Feliz created"
            Timeline.content.content "A low of cool things can happen now"
        ]
    ]
    Timeline.item [
        Timeline.marker [
            marker.isImage
            image.is32x32
            prop.children [ Html.img [ prop.src "https://via.placeholder.com/32" ] ]
        ]
        Timeline.content [
            Timeline.content.header "Feliz.Bulma started"
            Timeline.content.content "Now we can do cool stuff with fancy styles"
        ]
    ]
    Timeline.header [
        Bulma.tag [ color.isPrimary; prop.text "2020" ]
    ]
    Timeline.item [
        Timeline.marker [
            marker.isIcon
            prop.children [ Html.i [ prop.className "fas fa-flag" ] ]
        ]
        Timeline.content [
            Timeline.content.header "Fable 3 released"
            Timeline.content.content "What can be better than .NET tool compiling F# to JS?"
        ]
    ]
    Timeline.header [
        Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "End" ]
    ]
]
"""
            Timeline.timeline [
                Timeline.header [
                    Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "Start" ]
                ]
                Timeline.item [
                    Timeline.marker []
                    Timeline.content [
                        Timeline.content.header "Feliz created"
                        Timeline.content.content "A low of cool things can happen now"
                    ]
                ]
                Timeline.item [
                    Timeline.marker [
                        marker.isImage
                        image.is32x32
                        prop.children [ Html.img [ prop.src "https://via.placeholder.com/32" ] ]
                    ]
                    Timeline.content [
                        Timeline.content.header "Feliz.Bulma started"
                        Timeline.content.content "Now we can do cool stuff with fancy styles"
                    ]
                ]
                Timeline.header [
                    Bulma.tag [ color.isPrimary; prop.text "2020" ]
                ]
                Timeline.item [
                    Timeline.marker [
                        marker.isIcon
                        prop.children [ Html.i [ prop.className "fas fa-flag" ] ]
                    ]
                    Timeline.content [
                        Timeline.content.header "Fable 3 released"
                        Timeline.content.content "What can be better than .NET tool compiling F# to JS?"
                    ]
                ]
                Timeline.header [
                    Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "End" ]
                ]
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Colored timeline"
            code """Timeline.timeline [
    Timeline.header [ Bulma.tag [ color.isInfo; tag.isMedium; prop.text "Start" ] ]
    Timeline.item [
        color.isPrimary
        prop.children [
            Timeline.marker [ color.isPrimary ]
            Timeline.content [
                Timeline.content.header "Green things"
                Timeline.content.content "So nicely colored"
            ]
        ]
    ]
    Timeline.item [
        color.isDanger
        prop.children [
            Timeline.marker [ color.isDanger ]
            Timeline.content [
                Timeline.content.header "Red things"
                Timeline.content.content "Mind the red line"
            ]
        ]
    ]
    Timeline.item [
        color.isWarning
        prop.children [
            Timeline.marker [
                color.isWarning
                marker.isIcon
                prop.children [ Html.i [ prop.className "fas fa-exclamation" ] ]
            ]
            Timeline.content [
                Timeline.content.header "Orange things"
                Timeline.content.content "Watch out!"
            ]
        ]
    ]
    Timeline.header [ Bulma.tag [ color.isDark; tag.isMedium; prop.text "End" ] ]
]
"""
            Timeline.timeline [
                Timeline.header [ Bulma.tag [ color.isInfo; tag.isMedium; prop.text "Start" ] ]
                Timeline.item [
                    color.isPrimary
                    prop.children [
                        Timeline.marker [ color.isPrimary ]
                        Timeline.content [
                            Timeline.content.header "Green things"
                            Timeline.content.content "So nicely colored"
                        ]
                    ]
                ]
                Timeline.item [
                    color.isDanger
                    prop.children [
                        Timeline.marker [ color.isDanger ]
                        Timeline.content [
                            Timeline.content.header "Red things"
                            Timeline.content.content "Mind the red line"
                        ]
                    ]
                ]
                Timeline.item [
                    color.isWarning
                    prop.children [
                        Timeline.marker [
                            color.isWarning
                            marker.isIcon
                            prop.children [ Html.i [ prop.className "fas fa-exclamation" ] ]
                        ]
                        Timeline.content [
                            Timeline.content.header "Orange things"
                            Timeline.content.content "Watch out!"
                        ]
                    ]
                ]
                Timeline.header [ Bulma.tag [ color.isDark; tag.isMedium; prop.text "End" ] ]
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Centered timeline"
            code """Timeline.timeline [
    timeline.isCentered
    prop.children [
        Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2020" ] ]
        for _ in [1..5] do
            Timeline.item [
                Timeline.marker []
                Timeline.content [
                    Timeline.content.header "Something"
                    Timeline.content.content "But nicely centered"
                ]
            ]
        Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2021" ] ]
    ]
]
"""
            Timeline.timeline [
                timeline.isCentered
                prop.children [
                    Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2020" ] ]
                    for _ in [1..5] do
                        Timeline.item [
                            Timeline.marker []
                            Timeline.content [
                                Timeline.content.header "Something"
                                Timeline.content.content "But nicely centered"
                            ]
                        ]
                    Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2021" ] ]
                ]
            ]
        ]
        Bulma.content [
            Bulma.title.h5 "Right aligned timeline"
            code """Timeline.timeline [
    timeline.isRtl
    prop.children [
        Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2020" ] ]
        for i in [1..5] do
            Timeline.item [
                Timeline.marker []
                Timeline.content [
                    Timeline.content.header $"Event #{i}"
                    Timeline.content.content "Wow, it's so... RIGHT!"
                ]
            ]
        Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2021" ] ]
    ]
]
"""
            Timeline.timeline [
                timeline.isRtl
                prop.children [
                    Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2020" ] ]
                    for i in [1..5] do
                        Timeline.item [
                            Timeline.marker []
                            Timeline.content [
                                Timeline.content.header $"Event #{i}"
                                Timeline.content.content "Wow, it's so... RIGHT!"
                            ]
                        ]
                    Timeline.header [ Bulma.tag [ color.isPrimary; tag.isMedium; prop.text "2021" ] ]
                ]
            ]
        ]
    ]

let view =
    ComponentView
        "Timeline"
        "Feliz.Bulma.Timeline"
        "https://wikiki.github.io/components/timeline/"
        description
        (installationView "Feliz.Bulma.Timeline" "bulma-timeline" "bulma-timeline")
