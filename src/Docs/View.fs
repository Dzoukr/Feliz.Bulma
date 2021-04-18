module Docs.View

open Feliz
open Feliz.Bulma
open Docs.Router
open Feliz.Router
open Docs.State

let menuPart (model:Model) =
    let item (t:string) p =
        let isActive =
            if model.CurrentPage = p then [ helpers.isActive; color.hasBackgroundPrimary ] else []
        Bulma.menuItem.a [
            yield! isActive
            yield prop.text t
            yield prop.href (Router.getHref p)
        ]

    Bulma.menu [
        Bulma.menuLabel "General"
        Bulma.menuList [
            item "Overview" Overview
            item "Installation" Installation
            item "API description" APIDescription
        ]
        Bulma.menuLabel "Documentation"
        Bulma.menuList [
            item "Overview" DocumentationOverview
            item "Button" DocumentationButton
            item "Card" DocumentationCard
            item "Form" DocumentationForm
            item "Modal" DocumentationModal
            item "Navbar" DocumentationNavbar
        ]
        Bulma.menuLabel "Components"
        Bulma.menuList [
            item "QuickView" QuickView
            item "DateTimePicker" DateTimePicker
            item "Tooltip" Tooltip
            item "Checkradio" Checkradio
            item "Popover" Popover
            item "PageLoader" PageLoader
            item "Switch" Switch
            item "Divider" Divider
            item "Badge" Badge
            item "Slider" Slider
            item "Timeline" Timeline
            item "TagsInput" TagsInput
        ]
    ]


let contentPart model =
    match model.CurrentPage with
    | Overview -> Views.Bulma.overview
    | Installation -> Views.Bulma.installation
    | APIDescription -> Views.Bulma.apiDescription
    | DocumentationOverview -> Views.Documentation.overview
    | DocumentationButton -> Views.Documentation.button
    | DocumentationCard -> Views.Documentation.card
    | DocumentationForm -> Views.Documentation.form
    | DocumentationModal -> Views.Documentation.modal
    | DocumentationNavbar -> Views.Documentation.navbar
    | QuickView -> Views.QuickView.view
    | DateTimePicker -> Views.DateTimePicker.view
    | Tooltip -> Views.Tooltip.view
    | Checkradio -> Views.Checkradio.view
    | Popover -> Views.Popover.view
    | PageLoader -> Views.PageLoader.view
    | Switch -> Views.Switch.view
    | Divider -> Views.Divider.view
    | Badge -> Views.Badge.view
    | Slider -> Views.Slider.view
    | Timeline -> Views.Timeline.view
    | TagsInput -> Views.TagsInput.view

let view (model : Model) (dispatch : Msg -> unit) =
    let render =
        Bulma.container [
            Bulma.section [
                Bulma.tile [
                    tile.isAncestor
                    prop.children [
                        Bulma.tile [
                            tile.is2
                            prop.children (menuPart model)
                        ]
                        Bulma.tile (contentPart model)
                    ]
                ]
            ]
        ]
    React.router [
        router.onUrlChanged (parseUrl >> UrlChanged >> dispatch)
        router.children render
    ]
