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
        Bulma.menuLabel "Feliz.Bulma.Extensions.QuickView"
        Bulma.menuList [
            item "Overview" QuickViewOverview
            item "Installation" QuickViewInstallation
        ]
        Bulma.menuLabel "Feliz.Bulma.Extensions.Calendar"
        Bulma.menuList [
            item "Overview" CalendarOverview
            item "Installation" CalendarInstallation
        ]
    ]

let contentPart model dispatch =
    match model.CurrentPage with
    | BulmaOverview -> Views.Bulma.overview
    | BulmaInstallation -> Views.Bulma.installation
    | BulmaAPIDescription -> Views.Bulma.apiDescription
    | QuickViewOverview -> Views.QuickView.overview model dispatch
    | QuickViewInstallation -> Views.QuickView.installation
    | CalendarOverview -> Views.Calendar.overview model dispatch
    | CalendarInstallation -> Views.Calendar.installation
    
    
let view (model : Model) (dispatch : Msg -> unit) =
    let render =
        Bulma.container [
            Bulma.section [
                Bulma.tile [
                    tile.isAncestor
                    prop.children [
                        Bulma.tile [
                            tile.is3
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