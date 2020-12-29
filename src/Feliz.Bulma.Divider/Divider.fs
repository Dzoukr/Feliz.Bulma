namespace Feliz.Bulma

open Feliz
open Fable.Core
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] divider = "divider"

[<Erase>]
type Divider =
    static member inline divider (value:string) = value |> ElementBuilders.Div.valueStr ElementLiterals.divider
    static member inline divider (value:int) = value |> ElementBuilders.Div.valueInt ElementLiterals.divider
    static member inline divider xs = xs |> ElementBuilders.Div.props ElementLiterals.divider
