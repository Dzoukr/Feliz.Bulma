namespace Feliz.Bulma.Extensions.QuickView

open Feliz.Bulma

module private ClassLiterals =
    let [<Literal>] ``is-active`` = "is-active"

[<Fable.Core.Erase>]       
type quickview =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``