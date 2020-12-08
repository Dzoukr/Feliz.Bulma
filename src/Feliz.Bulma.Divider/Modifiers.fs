namespace Feliz.Bulma.Divider

open Feliz

[<Fable.Core.Erase>]
type divider =
    static member inline isLeft = Interop.mkAttr "className" "is-left"
    static member inline isRight = Interop.mkAttr "className" "is-right"
    static member inline isVertical = Interop.mkAttr "className" "is-vertical"
    static member inline text value = Interop.mkAttr "children" value

