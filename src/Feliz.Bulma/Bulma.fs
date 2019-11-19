namespace Feliz.Bulma

open Feliz

type Bulma =
    static member inline container props = ElementBuilders.Div.props "container" props
    static member inline container (elms:#seq<ReactElement>) = ElementBuilders.Div.children "container" elms
    static member inline container elm = ElementBuilders.Div.valueElm "container" elm
    static member inline container s = ElementBuilders.Div.valueStr "container" s
    static member inline container i = ElementBuilders.Div.valueInt "container" i
    
    static member inline level props = ElementBuilders.Nav.props "level" props
    static member inline level (elms:#seq<ReactElement>) = ElementBuilders.Nav.children "level" elms
    static member inline level elm = ElementBuilders.Nav.children "level" elm
    
    static member inline levelLeft props = ElementBuilders.Div.props "level-left" props
    static member inline levelLeft (elms:#seq<ReactElement>) = ElementBuilders.Div.children "level-left" elms
    static member inline levelLeft elm = ElementBuilders.Div.valueElm "level-left" elm
    static member inline levelLeft s = ElementBuilders.Div.valueStr "level-left" s
    static member inline levelLeft i = ElementBuilders.Div.valueInt "level-left" i
    
    static member inline levelRight props = ElementBuilders.Div.props "level-right" props
    static member inline levelRight (elms:#seq<ReactElement>) = ElementBuilders.Div.children "level-right" elms
    static member inline levelRight elm = ElementBuilders.Div.valueElm "level-right" elm
    static member inline levelRight s = ElementBuilders.Div.valueStr "level-right" s
    static member inline levelRight i = ElementBuilders.Div.valueInt "level-right" i
    
    static member inline levelItem props = ElementBuilders.Div.props "level-item" props
    static member inline levelItem (elms:#seq<ReactElement>) = ElementBuilders.Div.children "level-item" elms
    static member inline levelItem elm = ElementBuilders.Div.valueElm "level-item" elm
    static member inline levelItem s = ElementBuilders.Div.valueStr "level-item" s
    static member inline levelItem i = ElementBuilders.Div.valueInt "level-item" i

    static member inline media props = ElementBuilders.Article.props "media" props
    static member inline media (elms:#seq<ReactElement>) = ElementBuilders.Article.children "media" elms
    static member inline media elm = ElementBuilders.Article.valueElm "media" elm
    
    static member inline mediaLeft props = ElementBuilders.Div.props "media-left" props
    static member inline mediaLeft (elms:#seq<ReactElement>) = ElementBuilders.Div.children "media-left" elms
    static member inline mediaLeft elm = ElementBuilders.Div.valueElm "media-left" elm
    static member inline mediaLeft s = ElementBuilders.Div.valueStr "media-left" s
    static member inline mediaLeft i = ElementBuilders.Div.valueInt "media-left" i
    
    static member inline mediaRight props = ElementBuilders.Div.props "media-right" props
    static member inline mediaRight (elms:#seq<ReactElement>) = ElementBuilders.Div.children "media-right" elms
    static member inline mediaRight elm = ElementBuilders.Div.valueElm "media-right" elm
    static member inline mediaRight s = ElementBuilders.Div.valueStr "media-right" s
    static member inline mediaRight i = ElementBuilders.Div.valueInt "media-right" i
    
    static member inline mediaContent props = ElementBuilders.Div.props "media-content" props
    static member inline mediaContent (elms:#seq<ReactElement>) = ElementBuilders.Div.children "media-content" elms
    static member inline mediaContent elm = ElementBuilders.Div.valueElm "media-content" elm
    static member inline mediaContent s = ElementBuilders.Div.valueStr "media-content" s
    static member inline mediaContent i = ElementBuilders.Div.valueInt "media-content" i
    
    static member inline hero props = ElementBuilders.Div.props "hero" props
    static member inline hero (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero" elms
    static member inline hero elm = ElementBuilders.Div.valueElm "hero" elm
    static member inline hero s = ElementBuilders.Div.valueStr "hero" s
    static member inline hero i = ElementBuilders.Div.valueInt "hero" i
    
    static member inline heroBody props = ElementBuilders.Div.props "hero-body" props
    static member inline heroBody (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero-body" elms
    static member inline heroBody elm = ElementBuilders.Div.valueElm "hero-body" elm
    static member inline heroBody s = ElementBuilders.Div.valueStr "hero-body" s
    static member inline heroBody i = ElementBuilders.Div.valueInt "hero-body" i
    
    static member inline heroHead props = ElementBuilders.Div.props "hero-head" props
    static member inline heroHead (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero-head" elms
    static member inline heroHead elm = ElementBuilders.Div.valueElm "hero-head" elm
    static member inline heroHead s = ElementBuilders.Div.valueStr "hero-head" s
    static member inline heroHead i = ElementBuilders.Div.valueInt "hero-head" i

    static member inline heroFoot props = ElementBuilders.Div.props "hero-foot" props
    static member inline heroFoot (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero-foot" elms
    static member inline heroFoot elm = ElementBuilders.Div.valueElm "hero-foot" elm
    static member inline heroFoot s = ElementBuilders.Div.valueStr "hero-foot" s
    static member inline heroFoot i = ElementBuilders.Div.valueInt "hero-foot" i
    
    static member inline section props = ElementBuilders.Section.props "section" props
    static member inline section (elms:#seq<ReactElement>) = ElementBuilders.Section.children "section" elms
    
    static member inline footer props = ElementBuilders.Footer.props "footer" props
    static member inline footer (elms:#seq<ReactElement>) = ElementBuilders.Footer.children "footer" elms
    static member inline footer elm = ElementBuilders.Footer.valueElm "footer" elm
    
    static member inline tile props = ElementBuilders.Div.props "tile" props
    static member inline tile (elms:#seq<ReactElement>) = ElementBuilders.Div.children "tile" elms
    static member inline tile elm = ElementBuilders.Div.valueElm "tile" elm
    static member inline tile s = ElementBuilders.Div.valueStr "tile" s
    static member inline tile i = ElementBuilders.Div.valueInt "tile" i
    
    static member inline columns props = ElementBuilders.Div.props "columns" props
    static member inline columns (elms:#seq<ReactElement>) = ElementBuilders.Div.children "columns" elms
    static member inline columns elm = ElementBuilders.Div.valueElm "columns" elm
    static member inline columns s = ElementBuilders.Div.valueStr "columns" s
    static member inline columns i = ElementBuilders.Div.valueInt "columns" i
    
    static member inline column props = ElementBuilders.Div.props "column" props
    static member inline column (elms:#seq<ReactElement>) = ElementBuilders.Div.children "column" elms
    static member inline column elm = ElementBuilders.Div.valueElm "column" elm
    static member inline column s = ElementBuilders.Div.valueStr "column" s
    static member inline column i = ElementBuilders.Div.valueInt "column" i
    
    static member inline field props = ElementBuilders.Div.props "field" props
    static member inline field (elms:#seq<ReactElement>) = ElementBuilders.Div.children "field" elms
    static member inline field elm = ElementBuilders.Div.valueElm "field" elm
    static member inline field s = ElementBuilders.Div.valueStr "field" s
    static member inline field i = ElementBuilders.Div.valueInt "field" i
    
    static member inline label props = ElementBuilders.Label.props "label" props
    static member inline label (elms:#seq<ReactElement>) = ElementBuilders.Label.children "label" elms
    static member inline label elm = ElementBuilders.Label.valueElm "label" elm
    
    static member inline fieldLabel props = ElementBuilders.Div.props "field-label" props
    static member inline fieldLabel (elms:#seq<ReactElement>) = ElementBuilders.Div.children "field-label" elms
    static member inline fieldLabel elm = ElementBuilders.Div.valueElm "field-label" elm
    static member inline fieldLabel s = ElementBuilders.Div.valueStr "field-label" s
    static member inline fieldLabel i = ElementBuilders.Div.valueInt "field-label" i
    
    static member inline fieldBody props = ElementBuilders.Div.props "field-body" props
    static member inline fieldBody (elms:#seq<ReactElement>) = ElementBuilders.Div.children "field-body" elms
    static member inline fieldBody elm = ElementBuilders.Div.valueElm "field-body" elm
    static member inline fieldBody s = ElementBuilders.Div.valueStr "field-body" s
    static member inline fieldBody i = ElementBuilders.Div.valueInt "field-body" i
    
    static member inline control props = ElementBuilders.Div.props "control" props
    static member inline control (elms:#seq<ReactElement>) = ElementBuilders.Div.children "control" elms
    static member inline control elm = ElementBuilders.Div.valueElm "control" elm
    
    static member inline input props = ElementBuilders.Input.props "input" props
    
    static member inline textarea props = ElementBuilders.Textarea.props "textarea" props
    static member inline textarea (elms:#seq<ReactElement>) = ElementBuilders.Textarea.children "textarea" elms
    static member inline textarea elm = ElementBuilders.Textarea.valueElm "textarea" elm        
    
    static member inline select props = Html.div [ prop.className "select"; prop.children [ Html.select props ] ]
    static member inline select (elms:#seq<ReactElement>) = Html.div [ prop.className "select"; prop.children [ Html.select elms ] ]
    static member inline select (elm:ReactElement) = Html.div [ prop.className "select"; prop.children [ Html.select [ elm ] ] ]
    
    static member inline button props = ElementBuilders.Button.props "button" props
    static member inline button (elms:#seq<ReactElement>) = ElementBuilders.Button.children "button" elms
    static member inline button elm = ElementBuilders.Button.valueElm "button" elm
    static member inline button s = ElementBuilders.Button.valueStr "button" s
    static member inline button i = ElementBuilders.Button.valueInt "button" i
    
    static member inline checkboxLabel props = ElementBuilders.Label.props "checkbox" props
    static member inline checkboxLabel (elms:#seq<ReactElement>) = ElementBuilders.Label.children "checkbox" elms
    static member inline checkboxLabel elm = ElementBuilders.Label.valueElm "checkbox" elm
    
    static member inline checkboxInput props = ElementBuilders.Input.props "checkbox" props
    
    static member inline radioLabel props = ElementBuilders.Label.props "radio" props
    static member inline radioLabel (elms:#seq<ReactElement>) = ElementBuilders.Label.children "radio" elms
    static member inline radioLabel elm = ElementBuilders.Label.valueElm "radio" elm

    static member inline radioInput props = ElementBuilders.Input.props "radio" props
        
    static member inline icon props = ElementBuilders.Span.props "icon" props
    static member inline icon (elms:#seq<ReactElement>) = ElementBuilders.Span.children "icon" elms
    static member inline icon elm = ElementBuilders.Span.valueElm "icon" elm
    
    static member inline file props = ElementBuilders.Div.props "file" props
    static member inline file (elms:#seq<ReactElement>) = ElementBuilders.Div.children "file" elms
    static member inline file elm = ElementBuilders.Div.valueElm "file" elm
    
    static member inline fileLabel props = ElementBuilders.Label.props "file-label" props
    static member inline fileLabel (elms:#seq<ReactElement>) = ElementBuilders.Label.children "file-label" elms
    static member inline fileLabel elm = ElementBuilders.Label.valueElm "file-label" elm
    static member inline fileLabel s = ElementBuilders.Span.valueStr "file-label" s
    static member inline fileLabel i = ElementBuilders.Span.valueInt "file-label" i
    
    static member inline fileInput props = ElementBuilders.Input.props "file-input" props
    
    static member inline fileCta props = ElementBuilders.Span.props "file-cta" props
    static member inline fileCta (elms:#seq<ReactElement>) = ElementBuilders.Span.children "file-cta" elms
    static member inline fileCta elm = ElementBuilders.Span.valueElm "file-cta" elm
    
    static member inline fileIcon props = ElementBuilders.Span.props "file-icon" props
    static member inline fileIcon (elms:#seq<ReactElement>) = ElementBuilders.Span.children "file-icon" elms
    static member inline fileIcon elm = ElementBuilders.Span.valueElm "file-icon" elm
    
    static member inline fileName props = ElementBuilders.Span.props "file-name" props
    static member inline fileName (elms:#seq<ReactElement>) = ElementBuilders.Span.children "file-name" elms
    static member inline fileName elm = ElementBuilders.Span.valueElm "file-name" elm
    static member inline fileName s = ElementBuilders.Span.valueStr "file-name" s
    static member inline fileName i = ElementBuilders.Span.valueInt "file-name" i
    
    static member inline box props = ElementBuilders.Div.props "box" props
    static member inline box (elms:#seq<ReactElement>) = ElementBuilders.Div.children "box" elms
    static member inline box elm = ElementBuilders.Div.valueElm "box" elm
    static member inline box s = ElementBuilders.Div.valueStr "box" s
    static member inline box i = ElementBuilders.Div.valueInt "box" i
    
    static member inline buttons props = ElementBuilders.Div.props "buttons" props
    static member inline buttons (elms:#seq<ReactElement>) = ElementBuilders.Div.children "buttons" elms
    static member inline buttons elm = ElementBuilders.Div.valueElm "buttons" elm
    
    static member inline content props = ElementBuilders.Div.props "content" props
    static member inline content (elms:#seq<ReactElement>) = ElementBuilders.Div.children "content" elms
    static member inline content elm = ElementBuilders.Div.valueElm "content" elm
    static member inline content s = ElementBuilders.Div.valueStr "content" s
    static member inline content i = ElementBuilders.Div.valueInt "content" i
    
    static member inline delete props = ElementBuilders.Button.props "delete" props
    
    static member inline image props = ElementBuilders.Figure.props "image" props
    static member inline image (elms:#seq<ReactElement>) = ElementBuilders.Figure.children "image" elms
    static member inline image elm = ElementBuilders.Figure.valueElm "image" elm
    
    static member inline notification props = ElementBuilders.Div.props "notification" props
    static member inline notification (elms:#seq<ReactElement>) = ElementBuilders.Div.children "notification" elms
    static member inline notification elm = ElementBuilders.Div.valueElm "notification" elm
    static member inline notification s = ElementBuilders.Div.valueStr "notification" s
    static member inline notification i = ElementBuilders.Div.valueInt "notification" i
    
    static member inline progress props = ElementBuilders.Div.props "progress" props
    static member inline progress (elms:#seq<ReactElement>) = ElementBuilders.Div.children "progress" elms
    static member inline progress elm = ElementBuilders.Div.valueElm "progress" elm
    static member inline progress s = ElementBuilders.Div.valueStr "progress" s
    static member inline progress i = ElementBuilders.Div.valueInt "progress" i
    
    static member inline table props = ElementBuilders.Table.props "table" props
    static member inline table (elms:#seq<ReactElement>) = ElementBuilders.Table.children "table" elms
    static member inline table elm = ElementBuilders.Table.valueElm "table" elm
    
    static member inline tableContainer props = ElementBuilders.Div.props "table-container" props
    static member inline tableContainer (elms:#seq<ReactElement>) = ElementBuilders.Div.children "table-container" elms
    static member inline tableContainer elm = ElementBuilders.Div.valueElm "table-container" elm
    
    static member inline tag props = ElementBuilders.Span.props "tag" props
    static member inline tag (elms:#seq<ReactElement>) = ElementBuilders.Span.children "tag" elms
    static member inline tag elm = ElementBuilders.Span.valueElm "tag" elm
    static member inline tag s = ElementBuilders.Span.valueStr "tag" s
    static member inline tag i = ElementBuilders.Span.valueInt "tag" i
    
    static member inline tags props = ElementBuilders.Div.props "tags" props
    static member inline tags (elms:#seq<ReactElement>) = ElementBuilders.Div.children "tags" elms
    static member inline tags elm = ElementBuilders.Div.valueElm "tags" elm
    
    static member inline title props = ElementBuilders.H1.props "title" props
    static member inline title (elms:#seq<ReactElement>) = ElementBuilders.H1.children "title" elms
    static member inline title elm = ElementBuilders.H1.valueElm "title" elm
    static member inline title s = ElementBuilders.H1.valueStr "title" s
    static member inline title i = ElementBuilders.H1.valueInt "title" i
    
    static member inline title1 props = ElementBuilders.H1.props "title is-1" props
    static member inline title1 (elms:#seq<ReactElement>) = ElementBuilders.H1.children "title is-1" elms
    static member inline title1 elm = ElementBuilders.H1.valueElm "title is-1" elm
    static member inline title1 s = ElementBuilders.H1.valueStr "title is-1" s
    static member inline title1 i = ElementBuilders.H1.valueInt "title is-1" i

    static member inline title2 props = ElementBuilders.H2.props "title is-2" props
    static member inline title2 (elms:#seq<ReactElement>) = ElementBuilders.H2.children "title is-2" elms
    static member inline title2 elm = ElementBuilders.H2.valueElm "title is-2" elm
    static member inline title2 s = ElementBuilders.H2.valueStr "title is-2" s
    static member inline title2 i = ElementBuilders.H2.valueInt "title is-2" i

    static member inline title3 props = ElementBuilders.H3.props "title is-3" props
    static member inline title3 (elms:#seq<ReactElement>) = ElementBuilders.H3.children "title is-3" elms
    static member inline title3 elm = ElementBuilders.H3.valueElm "title is-3" elm
    static member inline title3 s = ElementBuilders.H3.valueStr "title is-3" s
    static member inline title3 i = ElementBuilders.H3.valueInt "title is-3" i

    static member inline title4 props = ElementBuilders.H4.props "title is-4" props
    static member inline title4 (elms:#seq<ReactElement>) = ElementBuilders.H4.children "title is-4" elms
    static member inline title4 elm = ElementBuilders.H4.valueElm "title is-4" elm
    static member inline title4 s = ElementBuilders.H4.valueStr "title is-4" s
    static member inline title4 i = ElementBuilders.H4.valueInt "title is-4" i

    static member inline title5 props = ElementBuilders.H5.props "title is-5" props
    static member inline title5 (elms:#seq<ReactElement>) = ElementBuilders.H5.children "title is-5" elms
    static member inline title5 elm = ElementBuilders.H5.valueElm "title is-5" elm
    static member inline title5 s = ElementBuilders.H5.valueStr "title is-5" s
    static member inline title5 i = ElementBuilders.H5.valueInt "title is-5" i

    static member inline title6 props = ElementBuilders.H6.props "title is-6" props
    static member inline title6 (elms:#seq<ReactElement>) = ElementBuilders.H6.children "title is-6" elms
    static member inline title6 elm = ElementBuilders.H6.valueElm "title is-6" elm
    static member inline title6 s = ElementBuilders.H6.valueStr "title is-6" s
    static member inline title6 i = ElementBuilders.H6.valueInt "title is-6" i
    
    static member inline subtitle props = ElementBuilders.H2.props "subtitle" props
    static member inline subtitle (elms:#seq<ReactElement>) = ElementBuilders.H2.children "subtitle" elms
    static member inline subtitle elm = ElementBuilders.H2.valueElm "subtitle" elm
    static member inline subtitle s = ElementBuilders.H2.valueStr "subtitle" s
    static member inline subtitle i = ElementBuilders.H2.valueInt "subtitle" i
    
    static member inline subtitle1 props = ElementBuilders.H1.props "subtitle is-1" props
    static member inline subtitle1 (elms:#seq<ReactElement>) = ElementBuilders.H1.children "subtitle is-1" elms
    static member inline subtitle1 elm = ElementBuilders.H1.valueElm "subtitle is-1" elm
    static member inline subtitle1 s = ElementBuilders.H1.valueStr "subtitle is-1" s
    static member inline subtitle1 i = ElementBuilders.H1.valueInt "subtitle is-1" i

    static member inline subtitle2 props = ElementBuilders.H2.props "subtitle is-2" props
    static member inline subtitle2 (elms:#seq<ReactElement>) = ElementBuilders.H2.children "subtitle is-2" elms
    static member inline subtitle2 elm = ElementBuilders.H2.valueElm "subtitle is-2" elm
    static member inline subtitle2 s = ElementBuilders.H2.valueStr "subtitle is-2" s
    static member inline subtitle2 i = ElementBuilders.H2.valueInt "subtitle is-2" i
    
    static member inline subtitle3 props = ElementBuilders.H3.props "subtitle is-3" props
    static member inline subtitle3 (elms:#seq<ReactElement>) = ElementBuilders.H3.children "subtitle is-3" elms
    static member inline subtitle3 elm = ElementBuilders.H3.valueElm "subtitle is-3" elm
    static member inline subtitle3 s = ElementBuilders.H3.valueStr "subtitle is-3" s
    static member inline subtitle3 i = ElementBuilders.H3.valueInt "subtitle is-3" i

    static member inline subtitle4 props = ElementBuilders.H4.props "subtitle is-4" props
    static member inline subtitle4 (elms:#seq<ReactElement>) = ElementBuilders.H4.children "subtitle is-4" elms
    static member inline subtitle4 elm = ElementBuilders.H4.valueElm "subtitle is-4" elm
    static member inline subtitle4 s = ElementBuilders.H4.valueStr "subtitle is-4" s
    static member inline subtitle4 i = ElementBuilders.H4.valueInt "subtitle is-4" i

    static member inline subtitle5 props = ElementBuilders.H5.props "subtitle is-5" props
    static member inline subtitle5 (elms:#seq<ReactElement>) = ElementBuilders.H5.children "subtitle is-5" elms
    static member inline subtitle5 elm = ElementBuilders.H5.valueElm "subtitle is-5" elm
    static member inline subtitle5 s = ElementBuilders.H5.valueStr "subtitle is-5" s
    static member inline subtitle5 i = ElementBuilders.H5.valueInt "subtitle is-5" i

    static member inline subtitle6 props = ElementBuilders.H6.props "subtitle is-6" props
    static member inline subtitle6 (elms:#seq<ReactElement>) = ElementBuilders.H6.children "subtitle is-6" elms
    static member inline subtitle6 elm = ElementBuilders.H6.valueElm "subtitle is-6" elm
    static member inline subtitle6 s = ElementBuilders.H6.valueStr "subtitle is-6" s
    static member inline subtitle6 i = ElementBuilders.H6.valueInt "subtitle is-6" i
    
    static member inline breadcrumb props = ElementBuilders.Nav.props "breadcrumb" props
    static member inline breadcrumb (elms:#seq<ReactElement>) = ElementBuilders.Nav.children "breadcrumb" elms
    static member inline breadcrumb elm = ElementBuilders.Nav.valueElm "breadcrumb" elm
    
    static member inline card props = ElementBuilders.Div.props "card" props
    static member inline card (elms:#seq<ReactElement>) = ElementBuilders.Div.children "card" elms
    static member inline card elm = ElementBuilders.Div.valueElm "card" elm
    
    static member inline cardHeader props = ElementBuilders.Div.props "card-header" props
    static member inline cardHeader (elms:#seq<ReactElement>) = ElementBuilders.Div.children "card-header" elms
    static member inline cardHeader elm = ElementBuilders.Div.valueElm "card-header" elm
    
    static member inline cardHeaderTitle props = ElementBuilders.Div.props "card-header-title" props
    static member inline cardHeaderTitle (elms:#seq<ReactElement>) = ElementBuilders.Div.children "card-header-title" elms
    static member inline cardHeaderTitle elm = ElementBuilders.Div.valueElm "card-header-title" elm
    static member inline cardHeaderTitle s = ElementBuilders.Div.valueStr "card-header-title" s
    static member inline cardHeaderTitle i = ElementBuilders.Div.valueInt "card-header-title" i
    
    static member inline cardHeaderIcon props = ElementBuilders.Span.props "card-header-icon" props
    static member inline cardHeaderIcon (elms:#seq<ReactElement>) = ElementBuilders.Span.children "card-header-icon" elms
    static member inline cardHeaderIcon elm = ElementBuilders.Span.valueElm "card-header-icon" elm
    
    static member inline cardImage props = ElementBuilders.Div.props "card-image" props
    static member inline cardImage (elms:#seq<ReactElement>) = ElementBuilders.Div.children "card-image" elms
    static member inline cardImage elm = ElementBuilders.Div.valueElm "card-image" elm
    
    static member inline cardContent props = ElementBuilders.Div.props "card-content" props
    static member inline cardContent (elms:#seq<ReactElement>) = ElementBuilders.Div.children "card-content" elms
    static member inline cardContent elm = ElementBuilders.Div.valueElm "card-content" elm
    static member inline cardContent s = ElementBuilders.Div.valueStr "card-content" s
    static member inline cardContent i = ElementBuilders.Div.valueInt "card-content" i
    
    static member inline cardFooter props = ElementBuilders.Footer.props "card-footer" props
    static member inline cardFooter (elms:#seq<ReactElement>) = ElementBuilders.Footer.children "card-footer" elms
    static member inline cardFooter elm = ElementBuilders.Footer.valueElm "card-footer" elm
    
    static member inline cardFooterItem props = ElementBuilders.Div.props "card-footer-item" props
    static member inline cardFooterItem (elms:#seq<ReactElement>) = ElementBuilders.Div.children "card-footer-item" elms
    static member inline cardFooterItem elm = ElementBuilders.Div.valueElm "card-footer-item" elm
    static member inline cardFooterItem s = ElementBuilders.Div.valueStr "card-footer-item" s
    static member inline cardFooterItem i = ElementBuilders.Div.valueInt "card-footer-item" i
    
    static member inline dropdown props = ElementBuilders.Div.props "dropdown" props
    static member inline dropdown (elms:#seq<ReactElement>) = ElementBuilders.Div.children "dropdown" elms
    static member inline dropdown elm = ElementBuilders.Div.valueElm "dropdown" elm
    
    static member inline dropdownTrigger props = ElementBuilders.Div.props "dropdown-trigger" props
    static member inline dropdownTrigger (elms:#seq<ReactElement>) = ElementBuilders.Div.children "dropdown-trigger" elms
    static member inline dropdownTrigger elm = ElementBuilders.Div.valueElm "dropdown-trigger" elm
    
    static member inline dropdownMenu props = ElementBuilders.Div.props "dropdown-menu" props
    static member inline dropdownMenu (elms:#seq<ReactElement>) = ElementBuilders.Div.children "dropdown-menu" elms
    static member inline dropdownMenu elm = ElementBuilders.Div.valueElm "dropdown-menu" elm
    
    static member inline dropdownContent props = ElementBuilders.Div.props "dropdown-content" props
    static member inline dropdownContent (elms:#seq<ReactElement>) = ElementBuilders.Div.children "dropdown-content" elms
    static member inline dropdownContent elm = ElementBuilders.Div.valueElm "dropdown-content" elm
    
    static member inline dropdownItem props = ElementBuilders.Div.props "dropdown-item" props
    static member inline dropdownItem (elms:#seq<ReactElement>) = ElementBuilders.Div.children "dropdown-item" elms
    static member inline dropdownItem elm = ElementBuilders.Div.valueElm "dropdown-item" elm
    static member inline dropdownItem s = ElementBuilders.Div.valueStr "dropdown-item" s
    static member inline dropdownItem i = ElementBuilders.Div.valueInt "dropdown-item" i
    
    static member inline dropdownDivider props = ElementBuilders.Hr.props "dropdown-divider" props
    
    static member inline menu props = ElementBuilders.Aside.props "menu" props
    static member inline menu (elms:#seq<ReactElement>) = ElementBuilders.Aside.children "menu" elms
    static member inline menu elm = ElementBuilders.Aside.valueElm "menu" elm
    
    static member inline menuLabel props = ElementBuilders.P.props "menu-label" props
    static member inline menuLabel (elms:#seq<ReactElement>) = ElementBuilders.P.children "menu-label" elms
    static member inline menuLabel elm = ElementBuilders.P.valueElm "menu-label" elm
    static member inline menuLabel s = ElementBuilders.P.valueStr "menu-label" s
    static member inline menuLabel i = ElementBuilders.P.valueInt "menu-label" i
    
    static member inline menuList props = ElementBuilders.Ul.props "menu-list" props
    static member inline menuList (elms:#seq<ReactElement>) = ElementBuilders.Ul.children "menu-list" elms
    static member inline menuList elm = ElementBuilders.Ul.valueElm "menu-list" elm
    
    static member inline message props = ElementBuilders.Article.props "message" props
    static member inline message (elms:#seq<ReactElement>) = ElementBuilders.Article.children "message" elms
    static member inline message elm = ElementBuilders.Article.valueElm "message" elm
    
    static member inline messageHeader props = ElementBuilders.Div.props "message-header" props
    static member inline messageHeader (elms:#seq<ReactElement>) = ElementBuilders.Div.children "message-header" elms
    static member inline messageHeader elm = ElementBuilders.Div.valueElm "message-header" elm
    
    static member inline messageBody props = ElementBuilders.Div.props "message-body" props
    static member inline messageBody (elms:#seq<ReactElement>) = ElementBuilders.Div.children "message-body" elms
    static member inline messageBody elm = ElementBuilders.Div.valueElm "message-body" elm
    static member inline messageBody s = ElementBuilders.Div.valueStr "message-body" s
    static member inline messageBody i = ElementBuilders.Div.valueInt "message-body" i
    
    static member inline modal props = ElementBuilders.Div.props "modal" props
    static member inline modal (elms:#seq<ReactElement>) = ElementBuilders.Div.children "modal" elms
    static member inline modal elm = ElementBuilders.Div.valueElm "modal" elm
    
    static member inline modalBackground props = ElementBuilders.Div.props "modal-background" props
    
    static member inline modalContent props = ElementBuilders.Div.props "modal-content" props
    static member inline modalContent (elms:#seq<ReactElement>) = ElementBuilders.Div.children "modal-content" elms
    static member inline modalContent elm = ElementBuilders.Div.valueElm "modal-content" elm
    static member inline modalContent s = ElementBuilders.Div.valueStr "modal-content" s
    static member inline modalContent i = ElementBuilders.Div.valueInt "modal-content" i
    
    static member inline modalCard props = ElementBuilders.Div.props "modal-card" props
    static member inline modalCard (elms:#seq<ReactElement>) = ElementBuilders.Div.children "modal-card" elms
    static member inline modalCard elm = ElementBuilders.Div.valueElm "modal-card" elm
    
    static member inline modalCardHead props = ElementBuilders.Header.props "modal-card-head" props
    static member inline modalCardHead (elms:#seq<ReactElement>) = ElementBuilders.Header.children "modal-card-head" elms
    static member inline modalCardHead elm = ElementBuilders.Header.valueElm "modal-card-head" elm
    
    static member inline modalCardBody props = ElementBuilders.Section.props "modal-card-body" props
    static member inline modalCardBody (elms:#seq<ReactElement>) = ElementBuilders.Section.children "modal-card-body" elms
    static member inline modalCardBody elm = ElementBuilders.Section.valueElm "modal-card-body" elm
    
    static member inline modalCardFoot props = ElementBuilders.Footer.props "modal-card-foot" props
    static member inline modalCardFoot (elms:#seq<ReactElement>) = ElementBuilders.Footer.children "modal-card-foot" elms
    static member inline modalCardFoot elm = ElementBuilders.Footer.valueElm "modal-card-foot" elm
    
    static member inline navbar props = ElementBuilders.Nav.props "navbar" props
    static member inline navbar (elms:#seq<ReactElement>) = ElementBuilders.Nav.children "navbar" elms
    static member inline navbar elm = ElementBuilders.Nav.valueElm "navbar" elm
    
    static member inline navbarBrand props = ElementBuilders.Div.props "navbar-brand" props
    static member inline navbarBrand (elms:#seq<ReactElement>) = ElementBuilders.Div.children "navbar-brand" elms
    static member inline navbarBrand elm = ElementBuilders.Div.valueElm "navbar-brand" elm    
    
    static member inline navbarBurger props = ElementBuilders.A.props "navbar-burger" props
    static member inline navbarBurger (elms:#seq<ReactElement>) = ElementBuilders.A.children "navbar-burger" elms
    static member inline navbarBurger elm = ElementBuilders.A.valueElm "navbar-burger" elm
    
    static member inline navbarMenu props = ElementBuilders.Div.props "navbar-menu" props
    static member inline navbarMenu (elms:#seq<ReactElement>) = ElementBuilders.Div.children "navbar-menu" elms
    static member inline navbarMenu elm = ElementBuilders.Div.valueElm "navbar-menu" elm    

    static member inline navbarStart props = ElementBuilders.Div.props "navbar-start" props
    static member inline navbarStart (elms:#seq<ReactElement>) = ElementBuilders.Div.children "navbar-start" elms
    static member inline navbarStart elm = ElementBuilders.Div.valueElm "navbar-start" elm
    
    static member inline navbarEnd props = ElementBuilders.Div.props "navbar-end" props
    static member inline navbarEnd (elms:#seq<ReactElement>) = ElementBuilders.Div.children "navbar-end" elms
    static member inline navbarEnd elm = ElementBuilders.Div.valueElm "navbar-end" elm    

    static member inline navbarItem props = ElementBuilders.Div.props "navbar-item" props
    static member inline navbarItem (elms:#seq<ReactElement>) = ElementBuilders.Div.children "navbar-item" elms
    static member inline navbarItem elm = ElementBuilders.Div.valueElm "navbar-item" elm

    static member inline navbarLink props = ElementBuilders.A.props "navbar-link" props
    static member inline navbarLink (elms:#seq<ReactElement>) = ElementBuilders.A.children "navbar-link" elms
    static member inline navbarLink elm = ElementBuilders.A.valueElm "navbar-link" elm
    static member inline navbarLink s = ElementBuilders.A.valueStr "navbar-link" s
    static member inline navbarLink i = ElementBuilders.A.valueInt "navbar-link" i
    
    static member inline navbarDropdown props = ElementBuilders.Div.props "navbar-dropdown" props
    static member inline navbarDropdown (elms:#seq<ReactElement>) = ElementBuilders.Div.children "navbar-dropdown" elms
    static member inline navbarDropdown elm = ElementBuilders.Div.valueElm "navbar-dropdown" elm
    
    static member inline navbarDivider props = ElementBuilders.Hr.props "navbar-divider" props
    
    static member inline pagination props = ElementBuilders.Nav.props "pagination" props
    static member inline pagination (elms:#seq<ReactElement>) = ElementBuilders.Nav.children "pagination" elms
    static member inline pagination elm = ElementBuilders.Nav.valueElm "pagination" elm
    
    static member inline paginationPrevious props = ElementBuilders.A.props "pagination-previous" props
    static member inline paginationPrevious (elms:#seq<ReactElement>) = ElementBuilders.A.children "pagination-previous" elms
    static member inline paginationPrevious elm = ElementBuilders.A.valueElm "pagination-previous" elm
    static member inline paginationPrevious s = ElementBuilders.A.valueStr "pagination-previous" s
    static member inline paginationPrevious i = ElementBuilders.A.valueInt "pagination-previous" i
    
    static member inline paginationNext props = ElementBuilders.A.props "pagination-next" props
    static member inline paginationNext (elms:#seq<ReactElement>) = ElementBuilders.A.children "pagination-next" elms
    static member inline paginationNext elm = ElementBuilders.A.valueElm "pagination-next" elm
    static member inline paginationNext s = ElementBuilders.A.valueStr "pagination-next" s
    static member inline paginationNext i = ElementBuilders.A.valueInt "pagination-next" i
    
    static member inline paginationList props = ElementBuilders.Ul.props "pagination-list" props
    static member inline paginationList (elms:#seq<ReactElement>) = ElementBuilders.Ul.children "pagination-list" elms
    static member inline paginationList elm = ElementBuilders.Ul.valueElm "pagination-list" elm
    
    static member inline paginationLink props = ElementBuilders.A.props "pagination-link" props
    static member inline paginationLink (elms:#seq<ReactElement>) = ElementBuilders.A.children "pagination-link" elms
    static member inline paginationLink elm = ElementBuilders.A.valueElm "pagination-link" elm
    static member inline paginationLink s = ElementBuilders.A.valueStr "pagination-link" s
    static member inline paginationLink i = ElementBuilders.A.valueInt "pagination-link" i
    
    static member inline paginationEllipsis props = ElementBuilders.Span.props "pagination-ellipsis" props
    static member inline paginationEllipsis (elms:#seq<ReactElement>) = ElementBuilders.Span.children "pagination-ellipsis" elms
    static member inline paginationEllipsis elm = ElementBuilders.Span.valueElm "pagination-ellipsis" elm
    static member inline paginationEllipsis s = ElementBuilders.Span.valueStr "pagination-ellipsis" s
    static member inline paginationEllipsis i = ElementBuilders.Span.valueInt "pagination-ellipsis" i    