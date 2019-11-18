module Feliz.Bulma.PropertyBuilders

open Feliz

let mkClass (value:string) = Interop.mkAttr "className" value