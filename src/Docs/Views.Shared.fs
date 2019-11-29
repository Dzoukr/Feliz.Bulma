module Docs.Views.Shared

open Fable.Core
open Fable.Core.JsInterop
open Feliz

type Highlight =
    static member inline highlight (properties: IReactProperty list) =
        Interop.reactApi.createElement(JsInterop.importDefault "react-highlight", JsInterop.createObj !!properties)

let code (c:string) =
    Highlight.highlight [
        prop.className "fsharp"
        prop.text c
    ]