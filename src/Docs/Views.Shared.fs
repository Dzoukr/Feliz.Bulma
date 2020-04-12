module Docs.Views.Shared

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.Bulma

type Highlight =
    static member inline highlight (properties: IReactProperty list) =
        Interop.reactApi.createElement(JsInterop.importDefault "react-highlight", JsInterop.createObj !!properties)

let code (c:string) =
    Highlight.highlight [
        prop.className "fsharp"
        prop.text c
    ]

let installationView packageName yarnName =
    Html.div [
        Bulma.title.h1 (sprintf "%s - Installation" packageName)
        Html.hr []
        Bulma.content [
            Bulma.title.h4 "Using Femto (recommended)"
            Html.p [ prop.dangerouslySetInnerHTML "The easiest way is to use <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> which will take care of all dependencies including npm libraries." ]
            code (sprintf "femto install %s" packageName)
        ]
        Bulma.content [
            Bulma.title.h4 "Manual"
            Html.p "If you want to install this package manually, use usual NuGet package command"
            code (sprintf "Install-Package %s" packageName)
            Html.p "or using Paket"
            code (sprintf "paket add %s" packageName)
            Html.p "Please don't forget that this library has also dependencies on frontend (css styles), so you need to add it to package.json file using yarn / npm command"
            code (sprintf "yarn add %s" yarnName)
        ]
    ]