namespace Feliz.Bulma.Tooltip

open Feliz

[<Fable.Core.Erase>]       
type tooltip =
    static member inline text (txt:string) = Interop.mkAttr "data-tooltip" txt
    static member inline hasTooltipMultiline = Interop.mkAttr "className" "has-tooltip-multiline"
    static member inline hasTooltipTop = Interop.mkAttr "className" "has-tooltip-top"
    static member inline hasTooltipRight = Interop.mkAttr "className" "has-tooltip-right"
    static member inline hasTooltipBottom = Interop.mkAttr "className" "has-tooltip-bottom"
    static member inline hasTooltipLeft = Interop.mkAttr "className" "has-tooltip-left"
    static member inline hasTooltipPrimary = Interop.mkAttr "className" "has-tooltip-primary"
    static member inline hasTooltipInfo = Interop.mkAttr "className" "has-tooltip-info"
    static member inline hasTooltipSuccess = Interop.mkAttr "className" "has-tooltip-success"
    static member inline hasTooltipWarning = Interop.mkAttr "className" "has-tooltip-warning"
    static member inline hasTooltipDanger = Interop.mkAttr "className" "has-tooltip-danger"
    static member inline hasTooltipActive = Interop.mkAttr "className" "has-tooltip-active"