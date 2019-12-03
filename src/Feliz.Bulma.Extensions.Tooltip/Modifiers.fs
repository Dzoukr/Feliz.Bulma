namespace Feliz.Bulma.Extensions.Tooltip

open Feliz

module private ClassLiterals =
    let [<Literal>] ``has-tooltip-top`` = "has-tooltip-top"
    let [<Literal>] ``has-tooltip-right`` = "has-tooltip-right"
    let [<Literal>] ``has-tooltip-bottom`` = "has-tooltip-bottom"
    let [<Literal>] ``has-tooltip-left`` = "has-tooltip-left"
    let [<Literal>] ``has-tooltip-primary`` = "has-tooltip-primary"
    let [<Literal>] ``has-tooltip-info`` = "has-tooltip-info"
    let [<Literal>] ``has-tooltip-success`` = "has-tooltip-success"
    let [<Literal>] ``has-tooltip-warning`` = "has-tooltip-warning"
    let [<Literal>] ``has-tooltip-danger`` = "has-tooltip-danger"
    let [<Literal>] ``has-tooltip-active`` = "has-tooltip-active"
    let [<Literal>] ``has-tooltip-multiline`` = "has-tooltip-multiline"

[<Fable.Core.Erase>]       
type tooltip =
    static member inline text (txt:string) = Interop.mkAttr "data-tooltip" txt
    static member inline hasTooltipMultiline = Interop.mkAttr "className" ClassLiterals.``has-tooltip-multiline``
    static member inline hasTooltipTop = Interop.mkAttr "className" ClassLiterals.``has-tooltip-top``
    static member inline hasTooltipRight = Interop.mkAttr "className" ClassLiterals.``has-tooltip-right``
    static member inline hasTooltipBottom = Interop.mkAttr "className" ClassLiterals.``has-tooltip-bottom``
    static member inline hasTooltipLeft = Interop.mkAttr "className" ClassLiterals.``has-tooltip-left``
    static member inline hasTooltipPrimary = Interop.mkAttr "className" ClassLiterals.``has-tooltip-primary``
    static member inline hasTooltipInfo = Interop.mkAttr "className" ClassLiterals.``has-tooltip-info``
    static member inline hasTooltipSuccess = Interop.mkAttr "className" ClassLiterals.``has-tooltip-success``
    static member inline hasTooltipWarning = Interop.mkAttr "className" ClassLiterals.``has-tooltip-warning``
    static member inline hasTooltipDanger = Interop.mkAttr "className" ClassLiterals.``has-tooltip-danger``
    static member inline hasTooltipActive = Interop.mkAttr "className" ClassLiterals.``has-tooltip-active``