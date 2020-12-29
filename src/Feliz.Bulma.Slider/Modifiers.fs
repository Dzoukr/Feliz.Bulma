namespace Feliz.Bulma

open Feliz

[<Fable.Core.Erase>]
type slider =
    static member inline isVertical = Interop.mkAttr "orient" "vertical"
    static member inline isCircle = Interop.mkAttr "className" "is-circle"
    static member inline isFullWidth = Interop.mkAttr "className" "is-fullwidth"
    static member inline isSmall = Interop.mkAttr "className" "is-small"
    static member inline isMedium = Interop.mkAttr "className" "is-medium"
    static member inline isLarge = Interop.mkAttr "className" "is-large"

