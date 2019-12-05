namespace Feliz.Bulma.Checkradio

open Feliz

module private ClassLiterals =
    let [<Literal>] ``is-rtl`` = "is-rtl"
    let [<Literal>] ``is-small`` = "is-small"
    let [<Literal>] ``is-medium`` = "is-medium"
    let [<Literal>] ``is-large`` = "is-large"
    let [<Literal>] ``is-circle`` = "is-circle"
    let [<Literal>] ``is-block`` = "is-block"
    let [<Literal>] ``has-no-border`` = "has-no-border"
    let [<Literal>] ``has-background-color`` = "has-background-color"
   
[<Fable.Core.Erase>]       
type checkradio =
    static member inline isRtl = Interop.mkAttr "className" ClassLiterals.``is-rtl``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isCircle = PropertyBuilders.mkClass ClassLiterals.``is-circle``
    static member inline isBlock = PropertyBuilders.mkClass ClassLiterals.``is-block``
    static member inline hasNoBorder = PropertyBuilders.mkClass ClassLiterals.``has-no-border``
    static member inline hasBackgroundColor = PropertyBuilders.mkClass ClassLiterals.``has-background-color``
