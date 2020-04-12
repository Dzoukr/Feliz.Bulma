module Docs.View

open Domain
open Feliz
open Feliz.Bulma
open Feliz.Router
open Docs.Router

let menuPart model =
    let item (t:string) p =
        let isActive =
            if model.CurrentPage = p then [ helpers.isActive; color.hasBackgroundPrimary ] else []
        Bulma.menu.item.a [
            yield! isActive
            yield prop.text t
            yield prop.href (Router.getHref p)
        ]

    Bulma.menu [
        Bulma.menu.label "Feliz.Bulma"
        Bulma.menu.list [
            item "Overview" BulmaOverview
            item "Installation" BulmaInstallation
            item "API description" BulmaAPIDescription
        ]
        Bulma.menu.label "Feliz.Bulma.QuickView"
        Bulma.menu.list [
            item "Overview" QuickViewOverview
            item "Installation" QuickViewInstallation
        ]
        Bulma.menu.label "Feliz.Bulma.Calendar"
        Bulma.menu.list [
            item "Overview" CalendarOverview
            item "Installation" CalendarInstallation
        ]
        Bulma.menu.label "Feliz.Bulma.Tooltip"
        Bulma.menu.list [
            item "Overview" TooltipOverview
            item "Installation" TooltipInstallation
        ]
        Bulma.menu.label "Feliz.Bulma.Checkradio"
        Bulma.menu.list [
            item "Overview" CheckradioOverview
            item "Installation" CheckradioInstallation
        ]
        Bulma.menu.label "Feliz.Bulma.Popover"
        Bulma.menu.list [
            item "Overview" PopoverOverview
            item "Installation" PopoverInstallation
        ]
        Bulma.menu.label "Feliz.Bulma.PageLoader"
        Bulma.menu.list [
            item "Overview" PageLoaderOverview
            item "Installation" PageLoaderInstallation
        ]
    ]

let contentPart model dispatch =
    match model.CurrentPage with
    | BulmaOverview -> Views.Bulma.overview
    | BulmaInstallation -> Views.Bulma.installation
    | BulmaAPIDescription -> Views.Bulma.apiDescription
    | QuickViewOverview -> Views.QuickView.overview model dispatch
    | QuickViewInstallation -> Views.QuickView.installation
    | CalendarOverview -> Views.Calendar.overview
    | CalendarInstallation -> Views.Calendar.installation
    | TooltipOverview -> Views.Tooltip.overview
    | TooltipInstallation -> Views.Tooltip.installation
    | CheckradioOverview -> Views.Checkradio.overview
    | CheckradioInstallation -> Views.Checkradio.installation
    | PopoverOverview -> Views.Popover.overview
    | PopoverInstallation -> Views.Popover.installation
    | PageLoaderOverview -> Views.PageLoader.overview model dispatch
    | PageLoaderInstallation -> Views.PageLoader.installation

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
                        Bulma.tile (contentPart model dispatch)
                    ]
                ]
            ]
        ]
    Router.router [
        Router.onUrlChanged (Router.parseUrl >> UrlChanged >> dispatch)
        Router.application render
    ]