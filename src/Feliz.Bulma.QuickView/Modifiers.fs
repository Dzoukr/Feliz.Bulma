namespace Feliz.Bulma.QuickView

open Feliz

module private ClassLiterals =
    let [<Literal>] ``is-active`` = "is-active"

[<Fable.Core.Erase>]       
type quickview =
    static member inline isActive = Interop.mkAttr "className" ClassLiterals.``is-active``