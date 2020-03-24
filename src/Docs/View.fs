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
        Bulma.menuItem [
            yield! isActive
            yield prop.text t
            yield prop.href (Router.getHref p)
        ]
    
    Bulma.menu [
        Bulma.menuLabel "Feliz.Bulma"
        Bulma.menuList [
            item "Overview" BulmaOverview
            item "Installation" BulmaInstallation
            item "API description" BulmaAPIDescription
        ]
        Bulma.menuLabel "Feliz.Bulma.QuickView"
        Bulma.menuList [
            item "Overview" QuickViewOverview
            item "Installation" QuickViewInstallation
        ]
        Bulma.menuLabel "Feliz.Bulma.Calendar"
        Bulma.menuList [
            item "Overview" CalendarOverview
            item "Installation" CalendarInstallation
        ]
        Bulma.menuLabel "Feliz.Bulma.Tooltip"
        Bulma.menuList [
            item "Overview" TooltipOverview
            item "Installation" TooltipInstallation
        ]
        Bulma.menuLabel "Feliz.Bulma.Checkradio"
        Bulma.menuList [
            item "Overview" CheckradioOverview
            item "Installation" CheckradioInstallation
        ]
        Bulma.menuLabel "Feliz.Bulma.Popover"
        Bulma.menuList [
            item "Overview" PopoverOverview
            item "Installation" PopoverInstallation
        ]
        Bulma.menuLabel "Feliz.Bulma.PageLoader"
        Bulma.menuList [
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