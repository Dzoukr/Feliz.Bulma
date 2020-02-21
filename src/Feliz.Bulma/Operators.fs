module Feliz.Bulma.Operators

open Feliz

let (++) (prop1:IReactProperty) (prop2:IReactProperty) =
    ElementBuilders.Helpers.getClasses [prop1; prop2]
    |> fun classes -> prop.classes classes