namespace Feliz.Bulma

[<RequireQualifiedAccess>]        
module helpers =
    let isClearfix = PropertyBuilders.mkClass "is-clearfix"
    let isPulledLeft = PropertyBuilders.mkClass "is-pulled-left"
    let isPulledRight = PropertyBuilders.mkClass "is-pulled-right"
    let isMarginless = PropertyBuilders.mkClass "is-marginless"
    let isPaddingless = PropertyBuilders.mkClass "is-paddingless"
    let isOverlay = PropertyBuilders.mkClass "is-overlay"
    let isClipped = PropertyBuilders.mkClass "is-clipped"
    let isRadiusless = PropertyBuilders.mkClass "is-radiusless"
    let isShadowless = PropertyBuilders.mkClass "is-shadowless"
    let isUnselectable = PropertyBuilders.mkClass "is-unselectable"
    let isInvisible = PropertyBuilders.mkClass "is-invisible"
    let isHidden = PropertyBuilders.mkClass "is-hidden"
    let isSrOnly = PropertyBuilders.mkClass "is-sr-only"
    let isRelative = PropertyBuilders.mkClass "is-relative"
    let isBlock = PropertyBuilders.mkClass "is-block"
    let isFlex = PropertyBuilders.mkClass "is-flex"
    let isInline = PropertyBuilders.mkClass "is-inline"
    let isInlineBlock = PropertyBuilders.mkClass "is-inline-block"
    let isInlineFlex = PropertyBuilders.mkClass "is-inline-flex"

[<RequireQualifiedAccess>]        
module size =
    let isSize1 = PropertyBuilders.mkClass "is-size-1"
    let isSize2 = PropertyBuilders.mkClass "is-size-2"
    let isSize3 = PropertyBuilders.mkClass "is-size-3"
    let isSize4 = PropertyBuilders.mkClass "is-size-4"
    let isSize5 = PropertyBuilders.mkClass "is-size-5"
    let isSize6 = PropertyBuilders.mkClass "is-size-6"
    let isSize7 = PropertyBuilders.mkClass "is-size-7"
    
    let isSize1Mobile = PropertyBuilders.mkClass "is-size-1-mobile"
    let isSize2Mobile = PropertyBuilders.mkClass "is-size-2-mobile"
    let isSize3Mobile = PropertyBuilders.mkClass "is-size-3-mobile"
    let isSize4Mobile = PropertyBuilders.mkClass "is-size-4-mobile"
    let isSize5Mobile = PropertyBuilders.mkClass "is-size-5-mobile"
    let isSize6Mobile = PropertyBuilders.mkClass "is-size-6-mobile"
    let isSize7Mobile = PropertyBuilders.mkClass "is-size-7-mobile"

    let isSize1Tablet = PropertyBuilders.mkClass "is-size-1-tablet"
    let isSize2Tablet = PropertyBuilders.mkClass "is-size-2-tablet"
    let isSize3Tablet = PropertyBuilders.mkClass "is-size-3-tablet"
    let isSize4Tablet = PropertyBuilders.mkClass "is-size-4-tablet"
    let isSize5Tablet = PropertyBuilders.mkClass "is-size-5-tablet"
    let isSize6Tablet = PropertyBuilders.mkClass "is-size-6-tablet"
    let isSize7Tablet = PropertyBuilders.mkClass "is-size-7-tablet"
    
    let isSize1Touch = PropertyBuilders.mkClass "is-size-1-touch"
    let isSize2Touch = PropertyBuilders.mkClass "is-size-2-touch"
    let isSize3Touch = PropertyBuilders.mkClass "is-size-3-touch"
    let isSize4Touch = PropertyBuilders.mkClass "is-size-4-touch"
    let isSize5Touch = PropertyBuilders.mkClass "is-size-5-touch"
    let isSize6Touch = PropertyBuilders.mkClass "is-size-6-touch"
    let isSize7Touch = PropertyBuilders.mkClass "is-size-7-touch"

    let isSize1Desktop = PropertyBuilders.mkClass "is-size-1-desktop"
    let isSize2Desktop = PropertyBuilders.mkClass "is-size-2-desktop"
    let isSize3Desktop = PropertyBuilders.mkClass "is-size-3-desktop"
    let isSize4Desktop = PropertyBuilders.mkClass "is-size-4-desktop"
    let isSize5Desktop = PropertyBuilders.mkClass "is-size-5-desktop"
    let isSize6Desktop = PropertyBuilders.mkClass "is-size-6-desktop"
    let isSize7Desktop = PropertyBuilders.mkClass "is-size-7-desktop"

    let isSize1Widescreen = PropertyBuilders.mkClass "is-size-1-widescreen"
    let isSize2Widescreen = PropertyBuilders.mkClass "is-size-2-widescreen"
    let isSize3Widescreen = PropertyBuilders.mkClass "is-size-3-widescreen"
    let isSize4Widescreen = PropertyBuilders.mkClass "is-size-4-widescreen"
    let isSize5Widescreen = PropertyBuilders.mkClass "is-size-5-widescreen"
    let isSize6Widescreen = PropertyBuilders.mkClass "is-size-6-widescreen"
    let isSize7Widescreen = PropertyBuilders.mkClass "is-size-7-widescreen"

    let isSize1FullHd = PropertyBuilders.mkClass "is-size-1-fullhd"
    let isSize2FullHd = PropertyBuilders.mkClass "is-size-2-fullhd"
    let isSize3FullHd = PropertyBuilders.mkClass "is-size-3-fullhd"
    let isSize4FullHd = PropertyBuilders.mkClass "is-size-4-fullhd"
    let isSize5FullHd = PropertyBuilders.mkClass "is-size-5-fullhd"
    let isSize6FullHd = PropertyBuilders.mkClass "is-size-6-fullhd"
    let isSize7FullHd = PropertyBuilders.mkClass "is-size-7-fullhd"

[<RequireQualifiedAccess>]        
module text =
    let isFamilySansSerif = PropertyBuilders.mkClass "is-family-sans-serif"
    let isFamilyMonospace = PropertyBuilders.mkClass "is-family-monospace"
    let isFamilyPrimary = PropertyBuilders.mkClass "is-family-primary"
    let isFamilySecondary = PropertyBuilders.mkClass "is-family-secondary"
    let isFamilyCode = PropertyBuilders.mkClass "is-family-code"
    
    let isCapitalized = PropertyBuilders.mkClass "is-capitalized"
    let isLowercase = PropertyBuilders.mkClass "is-lowercase"
    let isUppercase = PropertyBuilders.mkClass "is-uppercase"
    let isItalic= PropertyBuilders.mkClass "is-italic"
    
    let hasTextWeightLight = PropertyBuilders.mkClass "has-text-weight-light"
    let hasTextWeightNormal = PropertyBuilders.mkClass "has-text-weight-normal"
    let hasTextWeightMedium = PropertyBuilders.mkClass "has-text-weight-medium"
    let hasTextWeightSemibold = PropertyBuilders.mkClass "has-text-weight-semibold"
    let hasTextWeightBold = PropertyBuilders.mkClass "has-text-weight-bold"
    
    let hasTextCentered = PropertyBuilders.mkClass "has-text-centered"
    let hasTextJustified = PropertyBuilders.mkClass "has-text-justified"
    let hasTextLeft = PropertyBuilders.mkClass "has-text-left"
    let hasTextRight = PropertyBuilders.mkClass "has-text-right"
    
    let hasTextCenteredMobile = PropertyBuilders.mkClass "has-text-centered-mobile"
    let hasTextJustifiedMobile = PropertyBuilders.mkClass "has-text-justified-mobile"
    let hasTextLeftMobile = PropertyBuilders.mkClass "has-text-left-mobile"
    let hasTextRightMobile = PropertyBuilders.mkClass "has-text-right-mobile"
    
    let hasTextCenteredTablet = PropertyBuilders.mkClass "has-text-centered-tablet"
    let hasTextJustifiedTablet = PropertyBuilders.mkClass "has-text-justified-tablet"
    let hasTextLeftTablet = PropertyBuilders.mkClass "has-text-left-tablet"
    let hasTextRightTablet = PropertyBuilders.mkClass "has-text-right-tablet"

    let hasTextCenteredTabletOnly = PropertyBuilders.mkClass "has-text-centered-tablet-only"
    let hasTextJustifiedTabletOnly = PropertyBuilders.mkClass "has-text-justified-tablet-only"
    let hasTextLeftTabletOnly = PropertyBuilders.mkClass "has-text-left-tablet-only"
    let hasTextRightTabletOnly = PropertyBuilders.mkClass "has-text-right-tablet-only"

    let hasTextCenteredTouch = PropertyBuilders.mkClass "has-text-centered-touch"
    let hasTextJustifiedTouch = PropertyBuilders.mkClass "has-text-justified-touch"
    let hasTextLeftTouch = PropertyBuilders.mkClass "has-text-left-touch"
    let hasTextRightTouch = PropertyBuilders.mkClass "has-text-right-touch"

    let hasTextCenteredDesktop = PropertyBuilders.mkClass "has-text-centered-desktop"
    let hasTextJustifiedDesktop = PropertyBuilders.mkClass "has-text-justified-desktop"
    let hasTextLeftDesktop = PropertyBuilders.mkClass "has-text-left-desktop"
    let hasTextRightDesktop = PropertyBuilders.mkClass "has-text-right-desktop"
    

    let hasTextCenteredDesktopOnly = PropertyBuilders.mkClass "has-text-centered-desktop-only"
    let hasTextJustifiedDesktopOnly = PropertyBuilders.mkClass "has-text-justified-desktop-only"
    let hasTextLeftDesktopOnly = PropertyBuilders.mkClass "has-text-left-desktop-only"
    let hasTextRightDesktopOnly = PropertyBuilders.mkClass "has-text-right-desktop-only"

    let hasTextCenteredWidescreen = PropertyBuilders.mkClass "has-text-centered-widescreen"
    let hasTextJustifiedWidescreen = PropertyBuilders.mkClass "has-text-justified-widescreen"
    let hasTextLeftWidescreen = PropertyBuilders.mkClass "has-text-left-widescreen"
    let hasTextRightWidescreen = PropertyBuilders.mkClass "has-text-right-widescreen"

    let hasTextCenteredWidescreenOnly = PropertyBuilders.mkClass "has-text-centered-widescreen-only"
    let hasTextJustifiedWidescreenOnly = PropertyBuilders.mkClass "has-text-justified-widescreen-only"
    let hasTextLeftWidescreenOnly = PropertyBuilders.mkClass "has-text-left-widescreen-only"
    let hasTextRightWidescreenOnly = PropertyBuilders.mkClass "has-text-right-widescreen-only"

    let hasTextCenteredFullHd = PropertyBuilders.mkClass "has-text-centered-fullhd"
    let hasTextJustifiedFullHd = PropertyBuilders.mkClass "has-text-justified-fullhd"
    let hasTextLeftFullHd = PropertyBuilders.mkClass "has-text-left-fullhd"
    let hasTextRightFullHd = PropertyBuilders.mkClass "has-text-right-fullhd"    
    
[<RequireQualifiedAccess>]        
module color =
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"
    
    let hasTextWhite = PropertyBuilders.mkClass "has-text-white"
    let hasTextBlack = PropertyBuilders.mkClass "has-text-black"
    let hasTextLight = PropertyBuilders.mkClass "has-text-light"
    let hasTextDark = PropertyBuilders.mkClass "has-text-dark"
    let hasTextPrimary = PropertyBuilders.mkClass "has-text-primary"
    let hasTextInfo = PropertyBuilders.mkClass "has-text-info"
    let hasTextLink = PropertyBuilders.mkClass "has-text-link"
    let hasTextSuccess = PropertyBuilders.mkClass "has-text-success"
    let hasTextWarning = PropertyBuilders.mkClass "has-text-warning"
    let hasTextDanger = PropertyBuilders.mkClass "has-text-danger"
    let hasTextBlackBis = PropertyBuilders.mkClass "has-text-black-bis"
    let hasTextBlackTer = PropertyBuilders.mkClass "has-text-black-ter"
    let hasTextGreyDarker = PropertyBuilders.mkClass "has-text-grey-darker"
    let hasTextGreyDark = PropertyBuilders.mkClass "has-text-grey-dark"
    let hasTextGrey = PropertyBuilders.mkClass "has-text-grey"
    let hasTextGreyLight = PropertyBuilders.mkClass "has-text-grey-light"
    let hasTextGreyLighter = PropertyBuilders.mkClass "has-text-grey-lighter"
    let hasTextWhiteTer = PropertyBuilders.mkClass "has-text-white-ter"
    let hasTextWhiteBis = PropertyBuilders.mkClass "has-text-white-bis"
    
    let hasBackgroundWhite = PropertyBuilders.mkClass "has-background-white"
    let hasBackgroundBlack = PropertyBuilders.mkClass "has-background-black"
    let hasBackgroundLight = PropertyBuilders.mkClass "has-background-light"
    let hasBackgroundDark = PropertyBuilders.mkClass "has-background-dark"
    let hasBackgroundPrimary = PropertyBuilders.mkClass "has-background-primary"
    let hasBackgroundInfo = PropertyBuilders.mkClass "has-background-info"
    let hasBackgroundLink = PropertyBuilders.mkClass "has-background-link"
    let hasBackgroundSuccess = PropertyBuilders.mkClass "has-background-success"
    let hasBackgroundWarning = PropertyBuilders.mkClass "has-background-warning"
    let hasBackgroundDanger = PropertyBuilders.mkClass "has-background-danger"
    let hasBackgroundBlackBis = PropertyBuilders.mkClass "has-background-black-bis"
    let hasBackgroundBlackTer = PropertyBuilders.mkClass "has-background-black-ter"
    let hasBackgroundGreyDarker = PropertyBuilders.mkClass "has-background-grey-darker"
    let hasBackgroundGreyDark = PropertyBuilders.mkClass "has-background-grey-dark"
    let hasBackgroundGrey = PropertyBuilders.mkClass "has-background-grey"
    let hasBackgroundGreyLight = PropertyBuilders.mkClass "has-background-grey-light"
    let hasBackgroundGreyLighter = PropertyBuilders.mkClass "has-background-grey-lighter"
    let hasBackgroundWhiteTer = PropertyBuilders.mkClass "has-background-white-ter"
    let hasBackgroundWhiteBis = PropertyBuilders.mkClass "has-background-white-bis"

[<RequireQualifiedAccess>]        
module image =
    let is16x16 = PropertyBuilders.mkClass "is-16x16"
    let is24x24 = PropertyBuilders.mkClass "is-24x24"
    let is32x32 = PropertyBuilders.mkClass "is-32x32"
    let is48x48 = PropertyBuilders.mkClass "is-48x48"
    let is64x64 = PropertyBuilders.mkClass "is-64x64"
    let is96x96 = PropertyBuilders.mkClass "is-96x96"
    let is128x128 = PropertyBuilders.mkClass "is-128x128"
    let isRounded = PropertyBuilders.mkClass "is-rounded"
    let isSquare = PropertyBuilders.mkClass "is-square"
    let is1by1 = PropertyBuilders.mkClass "is-1by1"
    let is5by4 = PropertyBuilders.mkClass "is-5by4"
    let is4by3 = PropertyBuilders.mkClass "is-4by3"
    let is3by2 = PropertyBuilders.mkClass "is-3by2"
    let is5by3 = PropertyBuilders.mkClass "is-5by3"
    let is16by9 = PropertyBuilders.mkClass "is-16by9"
    let is2by1 = PropertyBuilders.mkClass "is-2by1"
    let is3by1 = PropertyBuilders.mkClass "is-3by1"
    let is4by5 = PropertyBuilders.mkClass "is-4by5"
    let is3by4 = PropertyBuilders.mkClass "is-3by4"
    let is2by3 = PropertyBuilders.mkClass "is-2by3"
    let is3by5 = PropertyBuilders.mkClass "is-3by5"
    let is9by16 = PropertyBuilders.mkClass "is-9by16"
    let is1by2 = PropertyBuilders.mkClass "is-1by2"
    let is1by3 = PropertyBuilders.mkClass "is-1by3"
    let isFullwidth = PropertyBuilders.mkClass "is-fullwidth"
    let hasRatio = PropertyBuilders.mkClass "has-ratio"

[<RequireQualifiedAccess>]        
module progress =
    let value v = PropertyBuilders.mkValue v
    let max v = PropertyBuilders.mkMax v
    
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module table =    
    let isBordered = PropertyBuilders.mkClass "is-bordered"    
    let isStriped = PropertyBuilders.mkClass "is-striped"    
    let isNarrow = PropertyBuilders.mkClass "is-narrow"    
    let isHoverable = PropertyBuilders.mkClass "is-hoverable"    
    let isFullwidth = PropertyBuilders.mkClass "is-fullwidth"    

[<RequireQualifiedAccess>]        
module tr =    
    let isSelected = PropertyBuilders.mkClass "is-selected"    

[<RequireQualifiedAccess>]        
module tag =    
    let isNormal = PropertyBuilders.mkClass "is-normal"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isRounded = PropertyBuilders.mkClass "is-rounded"
    let isDelete = PropertyBuilders.mkClass "is-delete"
    
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module tags =
    let areSmall = PropertyBuilders.mkClass "are-small"
    let areMedium = PropertyBuilders.mkClass "are-medium"
    let areLarge = PropertyBuilders.mkClass "are-large"
    let hasAddons = PropertyBuilders.mkClass "has-addons"

[<RequireQualifiedAccess>]        
module title =
    let isSpaced = PropertyBuilders.mkClass "is-spaced"
    
[<RequireQualifiedAccess>]        
module tab =
    let isCentered = PropertyBuilders.mkClass "is-centered"
    let isRight = PropertyBuilders.mkClass "is-right"
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isBoxed = PropertyBuilders.mkClass "is-boxed"
    let isToggle = PropertyBuilders.mkClass "is-toggle"
    let isToggleRounded = PropertyBuilders.mkClass "is-toggle-rounded"
    let isFullwidth = PropertyBuilders.mkClass "is-fullwidth"

[<RequireQualifiedAccess>]        
module breadcrumb =
    let isCentered = PropertyBuilders.mkClass "is-centered"
    let isRight = PropertyBuilders.mkClass "is-right"
    let hasArrowSeparator = PropertyBuilders.mkClass "has-arrow-separator"
    let hasBulletSeparator = PropertyBuilders.mkClass "has-bullet-separator"
    let hasDotSeparator = PropertyBuilders.mkClass "has-dot-separator"
    let hasSucceedsSeparator = PropertyBuilders.mkClass "has-succeeds-separator"
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module cardHeaderTitle =
    let isCentered = PropertyBuilders.mkClass "is-centered"

[<RequireQualifiedAccess>]        
module dropdown =
    let isHoverable = PropertyBuilders.mkClass "is-hoverable"
    let isActive = PropertyBuilders.mkClass "is-active"
    let isRight = PropertyBuilders.mkClass "is-right"
    let isUp = PropertyBuilders.mkClass "is-up"

[<RequireQualifiedAccess>]
module notification =
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module modal =
    let close = PropertyBuilders.mkClass "modal-close"
    let isActive = PropertyBuilders.mkClass "is-active"

[<RequireQualifiedAccess>]        
module navbar =
    let isTransparent = PropertyBuilders.mkClass "is-transparent"
    
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module navbarMenu =
    let isActive = PropertyBuilders.mkClass "is-active"
    let isFixedTop = PropertyBuilders.mkClass "is-fixed-top"
    let isFixedBottom = PropertyBuilders.mkClass "is-fixed-bottom"

[<RequireQualifiedAccess>]        
module navbarBurger =
    let isActive = PropertyBuilders.mkClass "is-active"

[<RequireQualifiedAccess>]        
module navbarDropdown =
    let isRight = PropertyBuilders.mkClass "is-right"
    let isBoxed = PropertyBuilders.mkClass "is-boxed"

[<RequireQualifiedAccess>]        
module navbarLink =
    let isArrowless = PropertyBuilders.mkClass "is-arrowless"

[<RequireQualifiedAccess>]        
module navbarItem =
    let isExpanded = PropertyBuilders.mkClass "is-expanded"
    let isTab = PropertyBuilders.mkClass "is-tab"
    let hasDropdown = PropertyBuilders.mkClass "has-dropdown"
    let hasDropdownUp = PropertyBuilders.mkClass "has-dropdown-up"
    let isHoverable = PropertyBuilders.mkClass "is-hoverable"
    let isActive = PropertyBuilders.mkClass "is-active"

[<RequireQualifiedAccess>]        
module pagination =
    let isCentered = PropertyBuilders.mkClass "is-centered"
    let isRounded = PropertyBuilders.mkClass "is-rounded"
    let isRight = PropertyBuilders.mkClass "is-right"
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module paginationLink =
    let isCurrent = PropertyBuilders.mkClass "is-current"

[<RequireQualifiedAccess>]        
module panel =
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module file =
    let hasName = PropertyBuilders.mkClass "has-name"
    let isRight = PropertyBuilders.mkClass "is-right"
    let isCentered = PropertyBuilders.mkClass "is-centered"
    let isFullwidth = PropertyBuilders.mkClass "is-fullwidth"
    let isBoxed = PropertyBuilders.mkClass "is-boxed"
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isNormal = PropertyBuilders.mkClass "is-normal"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module input =
    let file = PropertyBuilders.mkType "file"
    let text = PropertyBuilders.mkType "text"
    let password = PropertyBuilders.mkType "password"
    let email = PropertyBuilders.mkType "email"
    let tel = PropertyBuilders.mkType "tel"
    let submit = PropertyBuilders.mkType "submit"
    let reset = PropertyBuilders.mkType "reset"
    
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isRounded = PropertyBuilders.mkClass "is-rounded"
    let isHovered = PropertyBuilders.mkClass "is-hovered"
    let isFocused = PropertyBuilders.mkClass "is-focused"
    
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module button =
    let isStatic = PropertyBuilders.mkClass "is-static"
    let isOutlined = PropertyBuilders.mkClass "is-outlined"
    let isLoading = PropertyBuilders.mkClass "is-loading"
    let isRounded = PropertyBuilders.mkClass "is-rounded"
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isNormal = PropertyBuilders.mkClass "is-normal"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isFullwidth = PropertyBuilders.mkClass "is-fullwidth"
    let isInverted = PropertyBuilders.mkClass "is-inverted"
    let isHovered = PropertyBuilders.mkClass "is-hovered"
    let isFocused = PropertyBuilders.mkClass "is-focused"
    let isActive = PropertyBuilders.mkClass "is-active"
    let isSelected = PropertyBuilders.mkClass "is-selected"
    
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module buttons =
    let areSmall = PropertyBuilders.mkClass "are-small"
    let areMedium = PropertyBuilders.mkClass "are-medium"
    let areLarge = PropertyBuilders.mkClass "are-large"
    let hasAddons = PropertyBuilders.mkClass "has-addons"
    let isCentered = PropertyBuilders.mkClass "is-centered"
    let isRight = PropertyBuilders.mkClass "is-right"

[<RequireQualifiedAccess>]        
module fieldLabel =
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isNormal = PropertyBuilders.mkClass "is-normal"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module textarea =
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isNormal = PropertyBuilders.mkClass "is-normal"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isHovered = PropertyBuilders.mkClass "is-hovered"
    let isFocused = PropertyBuilders.mkClass "is-focused"
    let hasFixedSize = PropertyBuilders.mkClass "has-fixed-size"
    
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module field =
    let hasAddons = PropertyBuilders.mkClass "has-addons"
    let hasAddonsRight = PropertyBuilders.mkClass "has-addons-right"
    let hasAddonsCentered = PropertyBuilders.mkClass "has-addons-centered"
    let isGrouped = PropertyBuilders.mkClass "is-grouped"
    let isGroupedRight = PropertyBuilders.mkClass "is-grouped-right"
    let isGroupedCentered = PropertyBuilders.mkClass "is-grouped-centered"
    let isGroupedMultiline = PropertyBuilders.mkClass "is-grouped-multiline"
    let isHorizontal = PropertyBuilders.mkClass "is-horizontal"

[<RequireQualifiedAccess>] 
module message =
    let isWhite = PropertyBuilders.mkClass "is-white"
    let isBlack = PropertyBuilders.mkClass "is-black"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isLink = PropertyBuilders.mkClass "is-link"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module icon =
    let isLeft = PropertyBuilders.mkClass "is-left"
    let isRight = PropertyBuilders.mkClass "is-right"
    let isSmall = PropertyBuilders.mkClass "is-small"
    
    let hasTextWhite = PropertyBuilders.mkClass "has-text-white"
    let hasTextBlack = PropertyBuilders.mkClass "has-text-black"
    let hasTextLight = PropertyBuilders.mkClass "has-text-light"
    let hasTextDark = PropertyBuilders.mkClass "has-text-dark"
    let hasTextPrimary = PropertyBuilders.mkClass "has-text-primary"
    let hasTextInfo = PropertyBuilders.mkClass "has-text-info"
    let hasTextLink = PropertyBuilders.mkClass "has-text-link"
    let hasTextSuccess = PropertyBuilders.mkClass "has-text-success"
    let hasTextWarning = PropertyBuilders.mkClass "has-text-warning"
    let hasTextDanger = PropertyBuilders.mkClass "has-text-danger"
    let hasTextBlackBis = PropertyBuilders.mkClass "has-text-black-bis"
    let hasTextBlackTer = PropertyBuilders.mkClass "has-text-black-ter"
    let hasTextGreyDarker = PropertyBuilders.mkClass "has-text-grey-darker"
    let hasTextGreyDark = PropertyBuilders.mkClass "has-text-grey-dark"
    let hasTextGrey = PropertyBuilders.mkClass "has-text-grey"
    let hasTextGreyLight = PropertyBuilders.mkClass "has-text-grey-light"
    let hasTextGreyLighter = PropertyBuilders.mkClass "has-text-grey-lighter"
    let hasTextWhiteTer = PropertyBuilders.mkClass "has-text-white-ter"
    let hasTextWhiteBis = PropertyBuilders.mkClass "has-text-white-bis"
    
    module fa =
        let solid n = PropertyBuilders.mkClass (sprintf "fas fa-%s" n)
        let regular n = PropertyBuilders.mkClass (sprintf "far fa-%s" n)
        let light n = PropertyBuilders.mkClass (sprintf "fal fa-%s" n)
        let duotone n = PropertyBuilders.mkClass (sprintf "fad fa-%s" n)
        let brands n = PropertyBuilders.mkClass (sprintf "fab fa-%s" n)

[<RequireQualifiedAccess>]        
module select =
    let isFullwidth = PropertyBuilders.mkClass "is-fullwidth"
    let isMultiple = PropertyBuilders.mkClass "is-multiple"
    let isRounded = PropertyBuilders.mkClass "is-rounded"
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isNormal = PropertyBuilders.mkClass "is-normal"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isHovered = PropertyBuilders.mkClass "is-hovered"
    let isFocused = PropertyBuilders.mkClass "is-focused"
    let isActive = PropertyBuilders.mkClass "is-active"
    
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"

[<RequireQualifiedAccess>]        
module control =
    let hasIconsLeft = PropertyBuilders.mkClass "has-icons-left"
    let hasIconsRight = PropertyBuilders.mkClass "has-icons-right"
    let isExpanded = PropertyBuilders.mkClass "is-expanded"
    let isLoading = PropertyBuilders.mkClass "is-loading"
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module ol =
    let isLowerAlpha = PropertyBuilders.mkClass "is-lower-alpha"
    let isLowerRoman = PropertyBuilders.mkClass "is-lower-roman"
    let isUpperAlpha = PropertyBuilders.mkClass "is-upper-alpha"
    let isUpperRoman = PropertyBuilders.mkClass "is-upper-roman"

[<RequireQualifiedAccess>]        
module content =
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module delete =
    let isSmall = PropertyBuilders.mkClass "is-small"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module container =
    let isFluid = PropertyBuilders.mkClass "is-fluid"
    let isWidescreen = PropertyBuilders.mkClass "is-widescreen"
    let isFullHd = PropertyBuilders.mkClass "is-fullhd"

[<RequireQualifiedAccess>]        
module level =
    let isMobile = PropertyBuilders.mkClass "is-mobile"

[<RequireQualifiedAccess>]
module section =
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module hero =
    let isBold = PropertyBuilders.mkClass "is-bold"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isFullHeight = PropertyBuilders.mkClass "is-fullheight"
    let isFullHeightWithNavbar = PropertyBuilders.mkClass "is-fullheight-with-navbar"
    
    let isPrimary = PropertyBuilders.mkClass "is-primary"
    let isInfo = PropertyBuilders.mkClass "is-info"
    let isSuccess = PropertyBuilders.mkClass "is-success"
    let isWarning = PropertyBuilders.mkClass "is-warning"
    let isDanger = PropertyBuilders.mkClass "is-danger"
    let isLight = PropertyBuilders.mkClass "is-light"
    let isDark = PropertyBuilders.mkClass "is-dark"

[<RequireQualifiedAccess>]        
module tile =
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

[<RequireQualifiedAccess>]        
module column =
    let isMobile = PropertyBuilders.mkClass "is-mobile"
    let isDesktop = PropertyBuilders.mkClass "is-desktop"
    
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
    
    let isThreeQuarters = PropertyBuilders.mkClass "is-three-quarters"
    let isTwoThirds = PropertyBuilders.mkClass "is-two-thirds"
    let isHalf = PropertyBuilders.mkClass "is-half"
    let isOneThird = PropertyBuilders.mkClass "is-one-third"
    let isOneQuarter = PropertyBuilders.mkClass "is-one-quarter"
    let isFull = PropertyBuilders.mkClass "is-full"
    let isFourFifths = PropertyBuilders.mkClass "is-four-fifths"
    let isThreeFifths = PropertyBuilders.mkClass "is-three-fifths"
    let isTwoFifths = PropertyBuilders.mkClass "is-two-fifths"
    let isOneFifth = PropertyBuilders.mkClass "is-one-fifth"
    let isNarrowMobile = PropertyBuilders.mkClass "is-narrow-mobile"
    let isNarrowTablet = PropertyBuilders.mkClass "is-narrow-tablet"
    let isNarrowTouch = PropertyBuilders.mkClass "is-narrow-touch"
    let isNarrowDesktop = PropertyBuilders.mkClass "is-narrow-desktop"
    let isNarrowWidescreen = PropertyBuilders.mkClass "is-narrow-widescreen"
    let isNarrowFullhd = PropertyBuilders.mkClass "is-narrow-fullhd"
    
    let isOffset1 = PropertyBuilders.mkClass "is-offset-1"
    let isOffset2 = PropertyBuilders.mkClass "is-offset-2"
    let isOffset3 = PropertyBuilders.mkClass "is-offset-3"
    let isOffset4 = PropertyBuilders.mkClass "is-offset-4"
    let isOffset5 = PropertyBuilders.mkClass "is-offset-5"
    let isOffset6 = PropertyBuilders.mkClass "is-offset-6"
    let isOffset7 = PropertyBuilders.mkClass "is-offset-7"
    let isOffset8 = PropertyBuilders.mkClass "is-offset-8"
    let isOffset9 = PropertyBuilders.mkClass "is-offset-9"
    let isOffset10 = PropertyBuilders.mkClass "is-offset-10"
    let isOffset11 = PropertyBuilders.mkClass "is-offset-11"
    let isOffset12 = PropertyBuilders.mkClass "is-offset-12"
    let isOffsetThreeQuarters = PropertyBuilders.mkClass "is-offset-three-quarters"
    let isOffsetTwoThirds = PropertyBuilders.mkClass "is-offset-two-thirds"
    let isOffsetHalf = PropertyBuilders.mkClass "is-offset-half"
    let isOffsetOneThird = PropertyBuilders.mkClass "is-offset-one-third"
    let isOffsetOneQuarter = PropertyBuilders.mkClass "is-offset-one-quarter"
    let isOffsetFull = PropertyBuilders.mkClass "is-offset-full"
    let isOffsetFourFifths = PropertyBuilders.mkClass "is-offset-four-fifths"
    let isOffsetThreeFifths = PropertyBuilders.mkClass "is-offset-three-fifths"
    let isOffsetTwoFifths = PropertyBuilders.mkClass "is-offset-two-fifths"
    let isOffsetOneFifth = PropertyBuilders.mkClass "is-offset-one-fifth"
    
    let isThreeQuartersMobile = PropertyBuilders.mkClass "is-three-quarters-mobile"
    let isTwoThirdsMobile = PropertyBuilders.mkClass "is-two-thirds-mobile"
    let isHalfMobile = PropertyBuilders.mkClass "is-half-mobile"
    let isOneThirdMobile = PropertyBuilders.mkClass "is-one-third-mobile"
    let isOneQuarterMobile = PropertyBuilders.mkClass "is-one-quarter-mobile"
    let isFullMobile = PropertyBuilders.mkClass "is-full-mobile"
    let isFourFifthsMobile = PropertyBuilders.mkClass "is-four-fifths-mobile"
    let isThreeFifthsMobile = PropertyBuilders.mkClass "is-three-fifths-mobile"
    let isTwoFifthsMobile = PropertyBuilders.mkClass "is-two-fifths-mobile"
    let isOneFifthMobile = PropertyBuilders.mkClass "is-one-fifth-mobile"
    let isThreeQuartersTablet = PropertyBuilders.mkClass "is-three-quarters-tablet"
    let isTwoThirdsTablet = PropertyBuilders.mkClass "is-two-thirds-tablet"
    let isHalfTablet = PropertyBuilders.mkClass "is-half-tablet"
    let isOneThirdTablet = PropertyBuilders.mkClass "is-one-third-tablet"
    let isOneQuarterTablet = PropertyBuilders.mkClass "is-one-quarter-tablet"
    let isFullTablet = PropertyBuilders.mkClass "is-full-tablet"
    let isFourFifthsTablet = PropertyBuilders.mkClass "is-four-fifths-tablet"
    let isThreeFifthsTablet = PropertyBuilders.mkClass "is-three-fifths-tablet"
    let isTwoFifthsTablet = PropertyBuilders.mkClass "is-two-fifths-tablet"
    let isOneFifthTablet = PropertyBuilders.mkClass "is-one-fifth-tablet"
    let isThreeQuartersDesktop = PropertyBuilders.mkClass "is-three-quarters-desktop"
    let isTwoThirdsDesktop = PropertyBuilders.mkClass "is-two-thirds-desktop"
    let isHalfDesktop = PropertyBuilders.mkClass "is-half-desktop"
    let isOneThirdDesktop = PropertyBuilders.mkClass "is-one-third-desktop"
    let isOneQuarterDesktop = PropertyBuilders.mkClass "is-one-quarter-desktop"
    let isFullDesktop = PropertyBuilders.mkClass "is-full-desktop"
    let isFourFifthsDesktop = PropertyBuilders.mkClass "is-four-fifths-desktop"
    let isThreeFifthsDesktop = PropertyBuilders.mkClass "is-three-fifths-desktop"
    let isTwoFifthsDesktop = PropertyBuilders.mkClass "is-two-fifths-desktop"
    let isOneFifthDesktop = PropertyBuilders.mkClass "is-one-fifth-desktop"
    let isThreeQuartersWideScreen = PropertyBuilders.mkClass "is-three-quarters-widescreen"
    let isTwoThirdsWideScreen = PropertyBuilders.mkClass "is-two-thirds-widescreen"
    let isHalfWideScreen = PropertyBuilders.mkClass "is-half-widescreen"
    let isOneThirdWideScreen = PropertyBuilders.mkClass "is-one-third-widescreen"
    let isOneQuarterWideScreen = PropertyBuilders.mkClass "is-one-quarter-widescreen"
    let isFullWideScreen = PropertyBuilders.mkClass "is-full-widescreen"
    let isFourFifthsWideScreen = PropertyBuilders.mkClass "is-four-fifths-widescreen"
    let isThreeFifthsWideScreen = PropertyBuilders.mkClass "is-three-fifths-widescreen"
    let isTwoFifthsWideScreen = PropertyBuilders.mkClass "is-two-fifths-widescreen"
    let isOneFifthWideScreen = PropertyBuilders.mkClass "is-one-fifth-widescreen"
    let isThreeQuartersFullHd = PropertyBuilders.mkClass "is-three-quarters-fullhd"
    let isTwoThirdsFullHd = PropertyBuilders.mkClass "is-two-thirds-fullhd"
    let isHalfFullHd = PropertyBuilders.mkClass "is-half-fullhd"
    let isOneThirdFullHd = PropertyBuilders.mkClass "is-one-third-fullhd"
    let isOneQuarterFullHd = PropertyBuilders.mkClass "is-one-quarter-fullhd"
    let isFullFullHd = PropertyBuilders.mkClass "is-full-fullhd"
    let isFourFifthsFullHd = PropertyBuilders.mkClass "is-four-fifths-fullhd"
    let isThreeFifthsFullHd = PropertyBuilders.mkClass "is-three-fifths-fullhd"
    let isTwoFifthsFullHd = PropertyBuilders.mkClass "is-two-fifths-fullhd"
    let isOneFifthFullHd = PropertyBuilders.mkClass "is-one-fifth-fullhd"
    
    let isGapless = PropertyBuilders.mkClass "is-gapless"
    let isMultiline = PropertyBuilders.mkClass "is-multiline"
    let isVariable = PropertyBuilders.mkClass "is-variable"
    let isCentered = PropertyBuilders.mkClass "is-centered"
    let isVcentered = PropertyBuilders.mkClass "is-vcentered"    