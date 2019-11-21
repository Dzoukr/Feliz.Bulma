namespace Feliz.Bulma.Extensions

open Feliz
open Feliz.Bulma

type QuickView =
    static member inline quickview props = ElementBuilders.Div.props "quickview" props
    static member inline quickview (elms:#seq<ReactElement>) = ElementBuilders.Div.children "quickview" elms
    static member inline quickview elm = ElementBuilders.Div.valueElm "quickview" elm
    
    static member inline quickviewHeader props = ElementBuilders.Header.props "quickview-header" props
    static member inline quickviewHeader (elms:#seq<ReactElement>) = ElementBuilders.Header.children "quickview-header" elms
    static member inline quickviewHeader elm = ElementBuilders.Header.valueElm "quickview-header" elm
    
    static member inline quickviewBody props = ElementBuilders.Div.props "quickview-body" props
    static member inline quickviewBody (elms:#seq<ReactElement>) = ElementBuilders.Div.children "quickview-body" elms
    static member inline quickviewBody elm = ElementBuilders.Div.valueElm "quickview-body" elm
    
    static member inline quickviewBlock props = ElementBuilders.Div.props "quickview-block" props
    static member inline quickviewBlock (elms:#seq<ReactElement>) = ElementBuilders.Div.children "quickview-block" elms
    static member inline quickviewBlock elm = ElementBuilders.Div.valueElm "quickview-block" elm
    static member inline quickviewBlock s = ElementBuilders.Div.valueStr "quickview-block" s
    static member inline quickviewBlock i = ElementBuilders.Div.valueInt "quickview-block" i
    
    static member inline quickviewFooter props = ElementBuilders.Footer.props "quickview-footer" props
    static member inline quickviewFooter (elms:#seq<ReactElement>) = ElementBuilders.Footer.children "quickview-footer" elms
    static member inline quickviewFooter elm = ElementBuilders.Footer.valueElm "quickview-footer" elm
    