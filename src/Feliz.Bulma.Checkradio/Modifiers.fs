namespace Feliz.Bulma

open Feliz

[<Fable.Core.Erase>]
type checkradio =
    static member inline isRtl = Interop.mkAttr "className" "is-rtl"
    static member inline isSmall = PropertyBuilders.mkClass "is-small"
    static member inline isMedium = PropertyBuilders.mkClass "is-medium"
    static member inline isLarge = PropertyBuilders.mkClass "is-large"
    static member inline isCircle = PropertyBuilders.mkClass "is-circle"
    static member inline isBlock = PropertyBuilders.mkClass "is-block"
    static member inline hasNoBorder = PropertyBuilders.mkClass "has-no-border"
    static member inline hasBackgroundColor = PropertyBuilders.mkClass "has-background-color"
