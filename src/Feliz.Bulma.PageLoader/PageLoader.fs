namespace Feliz.Bulma.PageLoader

open Feliz
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] ``pageloader`` = "pageloader"
    let [<Literal>] ``title`` = "title"
    
type PageLoader =
    static member inline pageLoader props = ElementBuilders.Div.props ElementLiterals.``pageloader`` props
    static member inline pageLoader (elms:#seq<ReactElement>) = ElementBuilders.Div.children ElementLiterals.``pageloader`` elms
    static member inline pageLoader elm = ElementBuilders.Div.valueElm ElementLiterals.``pageloader`` elm

    static member inline title props = ElementBuilders.Span.props ElementLiterals.``title`` props
    static member inline title (elms:#seq<ReactElement>) = ElementBuilders.Span.children ElementLiterals.``title`` elms
    static member inline title elm = ElementBuilders.Span.valueElm ElementLiterals.``title`` elm
    static member inline title s = ElementBuilders.Span.valueStr ElementLiterals.``title`` s
    static member inline title i = ElementBuilders.Span.valueInt ElementLiterals.``title`` i