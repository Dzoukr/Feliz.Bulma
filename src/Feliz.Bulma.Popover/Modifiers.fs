namespace Feliz.Bulma.Popover

open Feliz

[<Fable.Core.Erase>]       
type popover =
    static member inline trigger = Interop.mkAttr "className" "is-popover-trigger"
    static member inline isActive = Interop.mkAttr "className" "is-popover-active"
    static member inline isTop = Interop.mkAttr "className" "is-popover-top"
    static member inline isRight = Interop.mkAttr "className" "is-popover-right"
    static member inline isBottom = Interop.mkAttr "className" "is-popover-bottom"
    static member inline isLeft = Interop.mkAttr "className" "is-popover-left"