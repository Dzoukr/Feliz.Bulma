module Feliz.Bulma.PropertyBuilders

open Feliz

let mkClass (value:string) = Interop.mkAttr "className" value
let mkType (value:string) = Interop.mkAttr "type" value