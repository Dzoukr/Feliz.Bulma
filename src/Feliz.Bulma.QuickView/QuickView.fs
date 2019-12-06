namespace Feliz.Bulma.QuickView

open Feliz
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] ``quickview`` = "quickview"
    let [<Literal>] ``quickview-header`` = "quickview-header"
    let [<Literal>] ``quickview-body`` = "quickview-body"
    let [<Literal>] ``quickview-block`` = "quickview-block"
    let [<Literal>] ``quickview-footer`` = "quickview-footer"

type QuickView =
    static member inline quickview props = ElementBuilders.Div.props ElementLiterals.``quickview`` props
    static member inline quickview (elms:#seq<ReactElement>) = ElementBuilders.Div.children ElementLiterals.``quickview`` elms
    static member inline quickview elm = ElementBuilders.Div.valueElm ElementLiterals.``quickview`` elm
    
    static member inline header props = ElementBuilders.Header.props ElementLiterals.``quickview-header`` props
    static member inline header (elms:#seq<ReactElement>) = ElementBuilders.Header.children ElementLiterals.``quickview-header`` elms
    static member inline header elm = ElementBuilders.Header.valueElm ElementLiterals.``quickview-header`` elm
    
    static member inline body props = ElementBuilders.Div.props ElementLiterals.``quickview-body`` props
    static member inline body (elms:#seq<ReactElement>) = ElementBuilders.Div.children ElementLiterals.``quickview-body`` elms
    static member inline body elm = ElementBuilders.Div.valueElm ElementLiterals.``quickview-body`` elm
    
    static member inline block props = ElementBuilders.Div.props ElementLiterals.``quickview-block`` props
    static member inline block (elms:#seq<ReactElement>) = ElementBuilders.Div.children ElementLiterals.``quickview-block`` elms
    static member inline block elm = ElementBuilders.Div.valueElm ElementLiterals.``quickview-block`` elm
    static member inline block s = ElementBuilders.Div.valueStr ElementLiterals.``quickview-block`` s
    static member inline block i = ElementBuilders.Div.valueInt ElementLiterals.``quickview-block`` i
    
    static member inline footer props = ElementBuilders.Footer.props ElementLiterals.``quickview-footer`` props
    static member inline footer (elms:#seq<ReactElement>) = ElementBuilders.Footer.children ElementLiterals.``quickview-footer`` elms
    static member inline footer elm = ElementBuilders.Footer.valueElm ElementLiterals.``quickview-footer`` elm