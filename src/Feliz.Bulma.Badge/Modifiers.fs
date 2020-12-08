namespace Feliz.Bulma.Badge

open Feliz

[<Fable.Core.Erase>]
type badge =
    static member inline title value = Interop.mkAttr "title" value
    static member inline value value = Interop.mkAttr "children" value
    static member inline isOutlined = Interop.mkAttr "className" "is-outlined"
    static member inline isTopLeft = Interop.mkAttr "className" "is-top-left"
    static member inline isTop = Interop.mkAttr "className" "is-top"
    static member inline isTopRight = Interop.mkAttr "className" "is-top-right"
    static member inline isRight = Interop.mkAttr "className" "is-right"
    static member inline isBottomRight = Interop.mkAttr "className" "is-bottom-right"
    static member inline isBottom = Interop.mkAttr "className" "is-bottom"
    static member inline isBottomLeft = Interop.mkAttr "className" "is-bottom-left"
    static member inline isLeft = Interop.mkAttr "className" "is-left"

