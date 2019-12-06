namespace Feliz.Bulma.QuickView

open Feliz

[<Fable.Core.Erase>]       
type quickview =
    static member inline isActive = Interop.mkAttr "className" "is-active"