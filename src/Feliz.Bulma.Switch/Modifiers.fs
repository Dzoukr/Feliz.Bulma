namespace Feliz.Bulma

open Feliz

[<Fable.Core.Erase>]
type switch =
    static member inline isRtl = Interop.mkAttr "className" "is-rtl"
    static member inline isSmall = PropertyBuilders.mkClass "is-small"
    static member inline isMedium = PropertyBuilders.mkClass "is-medium"
    static member inline isLarge = PropertyBuilders.mkClass "is-large"
    static member inline isThin = PropertyBuilders.mkClass "is-thin"
    static member inline isRounded = PropertyBuilders.mkClass "is-rounded"
    static member inline isOutlined = PropertyBuilders.mkClass "is-outlined"
