namespace Feliz.Bulma.Extensions.Calendar

open System
open Feliz
open Feliz.Bulma

[<Fable.Core.Erase>]       
type calendar =
    static member inline onDateSelected (handler: (DateTimeOffset * DateTimeOffset option) -> unit) = Interop.mkAttr "onDateSelected" handler
