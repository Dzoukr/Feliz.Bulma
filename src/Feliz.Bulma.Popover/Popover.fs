namespace Feliz.Bulma

open Feliz
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] ``popover`` = "popover"
    let [<Literal>] ``popover-content`` = "popover-content"

[<Fable.Core.Erase>]
type Popover =
    static member inline popover props = ElementBuilders.Div.props ElementLiterals.``popover`` props
    static member inline popover (elms:#seq<ReactElement>) = ElementBuilders.Div.children ElementLiterals.``popover`` elms
    static member inline popover elm = ElementBuilders.Div.valueElm ElementLiterals.``popover`` elm

    static member inline content props = ElementBuilders.Div.props ElementLiterals.``popover-content`` props
    static member inline content (elms:#seq<ReactElement>) = ElementBuilders.Div.children ElementLiterals.``popover-content`` elms
    static member inline content elm = ElementBuilders.Div.valueElm ElementLiterals.``popover-content`` elm
    static member inline content s = ElementBuilders.Div.valueStr ElementLiterals.``popover-content`` s
    static member inline content i = ElementBuilders.Div.valueInt ElementLiterals.``popover-content`` i
