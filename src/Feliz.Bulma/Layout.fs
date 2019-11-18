namespace Feliz.Bulma

open Feliz

type Layout =
    static member inline container props = ElementBuilders.Div.props "container" props
    static member inline container elms = ElementBuilders.Div.children "container" elms
    static member inline container elm = ElementBuilders.Div.valueElm "container" elm
    static member inline container s = ElementBuilders.Div.valueStr "container" s
    static member inline container i = ElementBuilders.Div.valueInt "container" i
    
    static member inline level props = ElementBuilders.Nav.props "level" props
    static member inline level elm = ElementBuilders.Nav.children "level" elm
    
    static member inline levelLeft props = ElementBuilders.Div.props "level-left" props
    static member inline levelLeft elms = ElementBuilders.Div.children "level-left" elms
    static member inline levelLeft elm = ElementBuilders.Div.valueElm "level-left" elm
    static member inline levelLeft s = ElementBuilders.Div.valueStr "level-left" s
    static member inline levelLeft i = ElementBuilders.Div.valueInt "level-left" i
    
    static member inline levelRight props = ElementBuilders.Div.props "level-right" props
    static member inline levelRight elms = ElementBuilders.Div.children "level-right" elms
    static member inline levelRight elm = ElementBuilders.Div.valueElm "level-right" elm
    static member inline levelRight s = ElementBuilders.Div.valueStr "level-right" s
    static member inline levelRight i = ElementBuilders.Div.valueInt "level-right" i
    
    static member inline levelItem props = ElementBuilders.Div.props "level-item" props
    static member inline levelItem elms = ElementBuilders.Div.children "level-item" elms
    static member inline levelItem elm = ElementBuilders.Div.valueElm "level-item" elm
    static member inline levelItem s = ElementBuilders.Div.valueStr "level-item" s
    static member inline levelItem i = ElementBuilders.Div.valueInt "level-item" i

    static member inline media props = ElementBuilders.Article.props "media" props
    static member inline media elms = ElementBuilders.Article.children "media" elms
    
    static member inline mediaLeft props = ElementBuilders.Div.props "media-left" props
    static member inline mediaLeft elms = ElementBuilders.Div.children "media-left" elms
    static member inline mediaLeft elm = ElementBuilders.Div.valueElm "media-left" elm
    static member inline mediaLeft s = ElementBuilders.Div.valueStr "media-left" s
    static member inline mediaLeft i = ElementBuilders.Div.valueInt "media-left" i
    
    static member inline mediaRight props = ElementBuilders.Div.props "media-right" props
    static member inline mediaRight elms = ElementBuilders.Div.children "media-right" elms
    static member inline mediaRight elm = ElementBuilders.Div.valueElm "media-right" elm
    static member inline mediaRight s = ElementBuilders.Div.valueStr "media-right" s
    static member inline mediaRight i = ElementBuilders.Div.valueInt "media-right" i
    
    static member inline mediaContent props = ElementBuilders.Div.props "media-content" props
    static member inline mediaContent elms = ElementBuilders.Div.children "media-content" elms
    static member inline mediaContent elm = ElementBuilders.Div.valueElm "media-content" elm
    static member inline mediaContent s = ElementBuilders.Div.valueStr "media-content" s
    static member inline mediaContent i = ElementBuilders.Div.valueInt "media-content" i
    
    static member inline hero props = ElementBuilders.Div.props "hero" props
    static member inline hero elms = ElementBuilders.Div.children "hero" elms
    static member inline hero elm = ElementBuilders.Div.valueElm "hero" elm
    static member inline hero s = ElementBuilders.Div.valueStr "hero" s
    static member inline hero i = ElementBuilders.Div.valueInt "hero" i
    
    static member inline heroBody props = ElementBuilders.Div.props "hero-body" props
    static member inline heroBody elms = ElementBuilders.Div.children "hero-body" elms
    static member inline heroBody elm = ElementBuilders.Div.valueElm "hero-body" elm
    static member inline heroBody s = ElementBuilders.Div.valueStr "hero-body" s
    static member inline heroBody i = ElementBuilders.Div.valueInt "hero-body" i
    
    static member inline heroHead props = ElementBuilders.Div.props "hero-head" props
    static member inline heroHead elms = ElementBuilders.Div.children "hero-head" elms
    static member inline heroHead elm = ElementBuilders.Div.valueElm "hero-head" elm
    static member inline heroHead s = ElementBuilders.Div.valueStr "hero-head" s
    static member inline heroHead i = ElementBuilders.Div.valueInt "hero-head" i

    static member inline heroFoot props = ElementBuilders.Div.props "hero-foot" props
    static member inline heroFoot elms = ElementBuilders.Div.children "hero-foot" elms
    static member inline heroFoot elm = ElementBuilders.Div.valueElm "hero-foot" elm
    static member inline heroFoot s = ElementBuilders.Div.valueStr "hero-foot" s
    static member inline heroFoot i = ElementBuilders.Div.valueInt "hero-foot" i
    
    static member inline section props = ElementBuilders.Section.props "section" props
    static member inline section elms = ElementBuilders.Section.children "section" elms
    
    static member inline footer props = ElementBuilders.Footer.props "footer" props
    static member inline footer elms = ElementBuilders.Footer.children "footer" elms
    
    static member inline tile props = ElementBuilders.Div.props "tile" props
    static member inline tile elms = ElementBuilders.Div.children "tile" elms
    static member inline tile elm = ElementBuilders.Div.valueElm "tile" elm
    static member inline tile s = ElementBuilders.Div.valueStr "tile" s
    static member inline tile i = ElementBuilders.Div.valueInt "tile" i
    
module Layout =
    [<RequireQualifiedAccess>]        
    module Container =
        let isFluid = PropertyBuilders.mkClass "is-fluid"
        let isWidescreen = PropertyBuilders.mkClass "is-widescreen"
        let isFullHd = PropertyBuilders.mkClass "is-fullhd"

    [<RequireQualifiedAccess>]        
    module Level =
        let isMobile = PropertyBuilders.mkClass "is-mobile"
    
    [<RequireQualifiedAccess>]
    module Section =
        let isMedium = PropertyBuilders.mkClass "is-medium"
        let isLarge = PropertyBuilders.mkClass "is-large"
    
    [<RequireQualifiedAccess>]        
    module Hero =
        let isBold = PropertyBuilders.mkClass "is-bold"
        let isMedium = PropertyBuilders.mkClass "is-medium"
        let isLarge = PropertyBuilders.mkClass "is-large"
        let isFullHeight = PropertyBuilders.mkClass "is-fullheight"
        let isFullHeightWithNavbar = PropertyBuilders.mkClass "is-fullheight-with-navbar"
    
    [<RequireQualifiedAccess>]        
    module Tile =
        let isAncestor = PropertyBuilders.mkClass "is-ancestor"
        let isParent = PropertyBuilders.mkClass "is-parent"
        let isChild = PropertyBuilders.mkClass "is-child"
        let isVertical = PropertyBuilders.mkClass "is-vertical"
        let is1 = PropertyBuilders.mkClass "is-1"
        let is2 = PropertyBuilders.mkClass "is-2"
        let is3 = PropertyBuilders.mkClass "is-3"
        let is4 = PropertyBuilders.mkClass "is-4"
        let is5 = PropertyBuilders.mkClass "is-5"
        let is6 = PropertyBuilders.mkClass "is-6"
        let is7 = PropertyBuilders.mkClass "is-7"
        let is8 = PropertyBuilders.mkClass "is-8"
        let is9 = PropertyBuilders.mkClass "is-9"
        let is10 = PropertyBuilders.mkClass "is-10"
        let is11 = PropertyBuilders.mkClass "is-11"
        let is12 = PropertyBuilders.mkClass "is-12"
