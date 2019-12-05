module internal Feliz.Bulma.Checkradio.PropertyBuilders

open Feliz

let inline mkClass (value:string) = Interop.mkAttr "className" value