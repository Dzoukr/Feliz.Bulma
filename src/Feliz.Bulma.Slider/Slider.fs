namespace Feliz.Bulma

open Feliz
open Fable.Core
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] slider = "slider"

[<Erase>]
type Slider =
    static member inline slider xs = xs |> ElementBuilders.Input.propsWithType ElementLiterals.slider prop.type'.range
