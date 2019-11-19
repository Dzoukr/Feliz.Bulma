module Feliz.Bulma.PropertyBuilders

open Feliz

let mkClass (value:string) = Interop.mkAttr "className" value
let mkType (value:string) = Interop.mkAttr "type" value
let mkValue (value:int) = Interop.mkAttr "value" value
let mkMax (value:int) = Interop.mkAttr "max" value