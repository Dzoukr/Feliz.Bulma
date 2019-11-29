module Docs.View

open System
open Domain
open Feliz
open Feliz.Bulma
open Feliz.Bulma.Extensions.QuickView
open Feliz.Bulma.Extensions.Calendar
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
//        Bulma.menuLabel "Feliz.Bulma.Extensions.QuickView"
//        Bulma.menuList [
//            Html.li [ Html.a [ prop.text "Overview"] ]
//            Html.li [ Html.a [ prop.text "Installation"] ]
//        ]
//        Bulma.menuLabel "Feliz.Bulma.Extensions.Calendar"
//        Bulma.menuList [
//            Html.li [ Html.a [ prop.text "Overview"] ]
//            Html.li [ Html.a [ prop.text "Installation"] ]
//        ]
    ]

let contentPart model =
    match model.CurrentPage with
    | BulmaOverview -> Views.Bulma.overview
    | BulmaInstallation -> Views.Bulma.installation
    | BulmaAPIDescription -> Views.Bulma.apiDescription
    
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
                        Bulma.tile (contentPart model)
                    ]
                ]
            ]
        ]
    Router.router [
        Router.onUrlChanged (Router.parseUrl >> UrlChanged >> dispatch)
        Router.application render
    ]
    
    
    
    
    
//    Bulma.section [
//        Bulma.hero [
//            Bulma.title "Feliz.Bulma |> Hello"
//        ]
//    ]

//    QuickView.quickview [
//        prop.className "is-active"
//        prop.children [
//            QuickView.header [
//                Html.div "AHOJ"
//            ]
//            QuickView.body [
//                QuickView.block "AAA"
//                QuickView.block "BBB"
//            ]
//            QuickView.footer [
//                Bulma.button "CLICK"
//            ]
//        ]
//    ]
    
        
//    Bulma.content [
//        
//        Bulma.field [
//            Bulma.fieldLabel "TEST"
//            Bulma.fieldBody [
//                
//                Calendar.calendar [
//                    prop.id "MOJE"
//                    prop.name model
//                    
//                    calendar.options [
//                        calendar.options.type'.datetime
//                        calendar.options.isRange true
//                        calendar.options.todayLabel model
//                        calendar.options.disabledDates [
//                            DateTime.Now
//                        ]
//                    ]
//                    calendar.onValueSelected (fun x ->
//                        Fable.Core.JS.console.log(x)
//                    )
//                    
//                ]
//                Bulma.button [
//                    prop.onClick (fun _ -> Nothing |> dispatch)
//                    prop.text "POME"
//                ]
//            ]
//        ]
//        
//    ]
    
    
    