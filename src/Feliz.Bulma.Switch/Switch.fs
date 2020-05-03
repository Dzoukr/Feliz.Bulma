namespace Feliz.Bulma.Switch

open Feliz
open Feliz.Bulma

module private ElementLiterals =
    [<Literal>]
    let switch = "switch"

type Switch =
    static member inline checkbox props =
        ElementBuilders.Input.propsWithType ElementLiterals.switch prop.type'.checkbox props
