namespace Feliz.Bulma.Carousel

open Feliz

[<Fable.Core.Erase>]
type timeline =
    static member inline isCentered = Interop.mkAttr "className" "is-centered"
    static member inline isRtl = Interop.mkAttr "className" "is-rtl"
