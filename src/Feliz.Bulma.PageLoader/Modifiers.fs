namespace Feliz.Bulma.PageLoader

open Feliz


[<Fable.Core.Erase>]       
type pageLoader =
    static member inline isActive = Interop.mkAttr "className" "is-active"
    static member inline isBottomToTop = Interop.mkAttr "className" "is-bottom-to-top"
    static member inline isRightToLeft = Interop.mkAttr "className" "is-right-to-left"
    static member inline isLeftToRight = Interop.mkAttr "className" "is-left-to-right"
    
    static member inline isWhite = Feliz.Bulma.color.isWhite
    static member inline isBlack = Feliz.Bulma.color.isBlack
    static member inline isLight = Feliz.Bulma.color.isLight
    static member inline isDark = Feliz.Bulma.color.isDark
    static member inline isPrimary = Feliz.Bulma.color.isPrimary
    static member inline isLink = Feliz.Bulma.color.isLink
    static member inline isInfo = Feliz.Bulma.color.isInfo
    static member inline isSuccess = Feliz.Bulma.color.isSuccess
    static member inline isWarning = Feliz.Bulma.color.isWarning
    static member inline isDanger = Feliz.Bulma.color.isDanger
    
    