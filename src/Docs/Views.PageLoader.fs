module Docs.Views.PageLoader

open Feliz
open Feliz.Bulma
open Shared
open Docs.Views


[<ReactComponent>]
let Description () =
    let isActive,setActive = React.useState(false)
    let toggleActive () =
        async {
            setActive(true)
            do! Async.Sleep 3000
            setActive(false)
        }
        |> Async.StartImmediate

    Html.div [
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Page Loader component"
            code """open Feliz.Bulma

PageLoader.pageLoader [
    pageLoader.isSuccess
    if model.ShowLoader then pageLoader.isActive
    prop.children [
        PageLoader.title "I am loading some awesomeness"
    ]
]

Bulma.button.a [
    button.isSuccess
    prop.text "Show page loader for 2 seconds"
    prop.onClick (fun _ -> ToggleLoader |> dispatch)
]"""

            Html.p "Code above will setup Page Loader:"
            PageLoader.pageLoader [
                pageLoader.isSuccess
                if isActive then pageLoader.isActive
                prop.children [
                    PageLoader.title "I am loading some awesomeness"
                ]
            ]

            Bulma.button.a [
                color.isSuccess
                prop.text "Show page loader for 3 seconds"
                prop.onClick (fun _ -> toggleActive ())
            ]

        ]
    ]

let view =
    ComponentView
        "PageLoader"
        "Feliz.Bulma.PageLoader"
        "https://wikiki.github.io/elements/pageloader/"
        (Description())
        (installationView "Feliz.Bulma.PageLoader" "bulma-pageloader" "bulma-pageloader/dist/css/bulma-pageloader.min.css")
