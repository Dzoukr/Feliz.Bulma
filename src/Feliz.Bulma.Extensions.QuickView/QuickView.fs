namespace Feliz.Bulma.Extensions.QuickView

open Feliz
open Feliz.Bulma

type QuickView =
    static member inline quickview props = ElementBuilders.Div.props "quickview" props
    static member inline quickview (elms:#seq<ReactElement>) = ElementBuilders.Div.children "quickview" elms
    static member inline quickview elm = ElementBuilders.Div.valueElm "quickview" elm
    
    static member inline header props = ElementBuilders.Header.props "quickview-header" props
    static member inline header (elms:#seq<ReactElement>) = ElementBuilders.Header.children "quickview-header" elms
    static member inline header elm = ElementBuilders.Header.valueElm "quickview-header" elm
    
    static member inline body props = ElementBuilders.Div.props "quickview-body" props
    static member inline body (elms:#seq<ReactElement>) = ElementBuilders.Div.children "quickview-body" elms
    static member inline body elm = ElementBuilders.Div.valueElm "quickview-body" elm
    
    static member inline block props = ElementBuilders.Div.props "quickview-block" props
    static member inline block (elms:#seq<ReactElement>) = ElementBuilders.Div.children "quickview-block" elms
    static member inline block elm = ElementBuilders.Div.valueElm "quickview-block" elm
    static member inline block s = ElementBuilders.Div.valueStr "quickview-block" s
    static member inline block i = ElementBuilders.Div.valueInt "quickview-block" i
    
    static member inline footer props = ElementBuilders.Footer.props "quickview-footer" props
    static member inline footer (elms:#seq<ReactElement>) = ElementBuilders.Footer.children "quickview-footer" elms
    static member inline footer elm = ElementBuilders.Footer.valueElm "quickview-footer" elm