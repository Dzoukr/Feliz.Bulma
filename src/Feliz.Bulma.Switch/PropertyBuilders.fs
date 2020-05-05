module internal Feliz.Bulma.Switch.PropertyBuilders

open Feliz

let inline mkClass (value: string) = Interop.mkAttr "className" value
