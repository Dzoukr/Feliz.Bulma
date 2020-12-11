module Docs.Views.Carousel

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Carousel
open Shared

let slideImages = [
    "https://images.unsplash.com/photo-1550921082-c282cdc432d6?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80"
    "https://images.unsplash.com/photo-1550945771-515f118cef86?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1000&q=80"
    "https://images.unsplash.com/photo-1550971264-3f7e4a7bb349?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80"
    "https://images.unsplash.com/photo-1550931937-2dfd45a40da0?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80"
    "https://images.unsplash.com/photo-1550930516-af8b8cc4f871?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1000&q=80"
]

let overview =
    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.Bulma.Carousel "
            Html.a
              [ prop.href "https://www.nuget.org/packages/Feliz.Bulma.Carousel/"
                prop.children
                    [ Html.img [ prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Carousel.svg?style=flat-square" ] ] ] ]
        Bulma.subtitle.h3 [
            Html.a [
                prop.href "https://bulma-carousel.onrender.com/"; prop.text "Carousel"
            ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.section [
            Carousel.carousel [
                carousel.slides [
                    for i in slideImages do
                        Bulma.card [
                            Bulma.cardImage [
                                Bulma.image [
                                    image.is16by9
                                    prop.children [
                                        Html.img [ prop.src i ]
                                    ]
                                ]
                            ]
                            Bulma.cardContent [
                                Html.div "Some content"
                            ]
                        ]
                ]
            ]
        ]
    ]
    |> (fun x ->
        Html.div [
            prop.children [ x ]
            prop.style [ style.width (length.percent 100) ]
        ]
    )

let installation = installationView "Feliz.Bulma.Carousel" "bulma-carousel" "bulma-carousel"
