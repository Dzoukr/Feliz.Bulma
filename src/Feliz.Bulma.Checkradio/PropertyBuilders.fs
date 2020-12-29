module internal Feliz.Bulma.PropertyBuilders

open Feliz

let inline mkClass (value:string) = Interop.mkAttr "className" value
