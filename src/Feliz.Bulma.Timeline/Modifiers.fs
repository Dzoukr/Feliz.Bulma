namespace Feliz.Bulma

open Feliz

[<Fable.Core.Erase>]
type timeline =
    static member inline isCentered = Interop.mkAttr "className" "is-centered"
    static member inline isRtl = Interop.mkAttr "className" "is-rtl"

[<Fable.Core.Erase>]
type marker =
    static member inline isImage = Interop.mkAttr "className" "is-image"
    static member inline isIcon = Interop.mkAttr "className" "is-icon"
