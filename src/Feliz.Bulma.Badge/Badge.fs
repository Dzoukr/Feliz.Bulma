namespace Feliz.Bulma

open Feliz
open Fable.Core
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] badge = "badge"

[<Erase>]
type Badge =
    static member inline badge (value:string) = value |> ElementBuilders.Span.valueStr ElementLiterals.badge
    static member inline badge (value:int) = value |> ElementBuilders.Span.valueInt ElementLiterals.badge
    static member inline badge xs = xs |> ElementBuilders.Span.props ElementLiterals.badge
