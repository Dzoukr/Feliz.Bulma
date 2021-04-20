module Docs.Views.Documentation

open Feliz
open Feliz.Bulma
open Shared

type Color =
    | Primary
    | Danger
    | Info
    | Link
    | Success
    | Warning
    | Black
    | Dark
    | Light
    | White

type ColorType = { Type: Color; Name: string; PropertyName: IReactProperty; }

let getColorInfo = function
        | Primary -> { Type = Primary; Name = "Primary"; PropertyName = Bulma.color.isPrimary; }
        | Danger ->  { Type = Danger; Name = "Danger"; PropertyName = Bulma.color.isDanger; }
        | Info ->  { Type = Info; Name = "Info"; PropertyName = Bulma.color.isInfo; }
        | Link ->  { Type = Link; Name = "Link"; PropertyName = Bulma.color.isLink; }
        | Success ->  { Type = Success; Name = "Success"; PropertyName = Bulma.color.isSuccess; }
        | Warning ->  { Type = Warning; Name = "Warning"; PropertyName = Bulma.color.isWarning; }
        | Black ->  { Type = Black; Name = "Black"; PropertyName = Bulma.color.isBlack; }
        | Dark ->  { Type = Dark; Name = "Dark"; PropertyName = Bulma.color.isDark; }
        | Light ->  { Type = Light; Name = "Light"; PropertyName = Bulma.color.isLight; }
        | White ->  { Type = White; Name = "White"; PropertyName = Bulma.color.isWhite; }

let getColorChooseButton (color: Color) (onClickCallback : Color -> unit) = 
        Bulma.button.button [ getColorInfo(color).PropertyName; prop.text(getColorInfo(color).Name); prop.onClick (fun _ -> onClickCallback(color)); ]


let overview =
    Html.div [ 
        Bulma.title "Feliz.Bulma - Documentation"
        Html.hr [] 
        Bulma.subtitle "Buttons"
   ]

let private sample (sampleButton: IReactProperty list) (sampleCode: string) = Bulma.columns [
    Bulma.column [ Bulma.button.a sampleButton ]
    Bulma.column [ code sampleCode ]
]

let button =
    Html.div [  Bulma.title "Feliz.Bulma - Documentation"
                Bulma.subtitle "Buttons"
                Html.hr [] 
                Bulma.content [
                    Bulma.title "Basic"
                    sample [ prop.text "Button" ] """Bulma.button.button [ prop.text "Button" ]"""
                 
                ]
                Bulma.content [
                    Bulma.title "Colors"
                    sample [ color.isWhite; prop.text "White"] """Bulma.button.button [
    Bulma.color.isWhite
    prop.text "White"
]"""
                    sample [ color.isLight; prop.text "Light"] """Bulma.button.button [
    Bulma.color.isLight
    prop.text "Light"
]"""
                    sample [ color.isDark; prop.text "Dark"] """Bulma.button.button [
    Bulma.color.isDark
    prop.text "Dark"
]"""
                    sample [ color.isPrimary; prop.text "Primary"] """Bulma.button.button [
    Bulma.color.isPrimary
    prop.text "Primary"
]"""
                    sample [ color.isSuccess; prop.text "Success"] """Bulma.button.button [
    Bulma.color.isSuccess
    prop.text "Success"
]"""
                    sample [ color.isInfo; prop.text "Info"] """Bulma.button.button [
    Bulma.color.isInfo
    prop.text "Info"
]"""
                    sample [ color.isDanger; prop.text "Danger"] """Bulma.button.button [
    Bulma.color.isDanger
    prop.text "Danger"
]"""
                    sample [ color.isWarning; prop.text "Warning"] """Bulma.button.button [
    Bulma.color.isWarning
    prop.text "Warning"
]"""
                    sample [ color.isLink; prop.text "Link"] """Bulma.button.button [
    Bulma.color.isLink
    prop.text "Link"
]"""
                ]
                Bulma.content [
                    Bulma.title "Sizes"
                    sample [ button.isSmall; prop.text "Small"] """Bulma.button.button [
    Bulma.button.isSmall
    prop.text "Small"
]"""
                    sample [ prop.text "Normal (Default)" ] """Bulma.button.button [ prop.text "Normal (Default)" ]"""
                    sample [ button.isMedium; prop.text "Medium"] """Bulma.button.button [
    Bulma.button.isMedium
    prop.text "Medium"
]"""
                    sample [ button.isLarge; prop.text "Large"] """Bulma.button.button [
    Bulma.button.isLarge
    prop.text "Large"
]"""
                ]
                Bulma.content [
                    Bulma.title "States"
                    sample [ button.isActive; prop.text "Active"] """Bulma.button.button [
    Bulma.button.isActive
    prop.text "Active"
]"""
                    sample [ prop.disabled true; prop.text "Disabled"] """Bulma.button.button [
    prop.disabled true
    prop.text "Disabled"
]"""
                    sample [ button.isFocused; prop.text "Focused"] """Bulma.button.button [
    Bulma.button.isFocused
    prop.text "Focused"
]"""
                    sample [ button.isHovered; prop.text "Hover"] """Bulma.button.button [
    Bulma.button.isHovered
    prop.text "Hover"
]"""
                    sample [ prop.text "Normal (Default)" ] """Bulma.button.button [ prop.text "Normal (Default)" ]"""
                    sample [ button.isLoading ] """Bulma.button.button [ Bulma.button.isLoading ]"""
                ]
                Bulma.content [
                    Bulma.title "Button group with addons"
                    Bulma.columns [
                        Bulma.column [
                            Bulma.field.div [
                                field.hasAddons
                                prop.children [
                                    Bulma.control.p [
                                        Bulma.button.button [
                                            Bulma.icon [ Html.i [ prop.className "fas fa-align-left" ] ]
                                            Html.span [ prop.text "Left" ]
                                        ]
                                    ]
                                    Bulma.control.p [
                                        Bulma.button.button [
                                            Bulma.icon [ Html.i [ prop.className "fas fa-align-center" ] ]
                                        ]
                                    ]
                                    Bulma.control.p [
                                        Bulma.button.button [
                                            Html.span [ prop.text "Right" ]
                                            Bulma.icon [ Html.i [ prop.className "fas fa-align-right" ] ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Bulma.column [ code """Bulma.field.div [
    Bulma.field.hasAddons
    prop.children [
        Bulma.control.p [
            Bulma.button.button [
                Bulma.icon [ Html.i [ prop.className "fas fa-align-left" ] ]
                Html.span [ prop.text "Left" ]
            ]
        ]
        Bulma.control.p [
            Bulma.button.button [
                Bulma.icon [ Html.i [ prop.className "fas fa-align-center" ] ]
            ]
        ]
        Bulma.control.p [
            Bulma.button.button [
                Html.span [ prop.text "Right" ]
                Bulma.icon [ Html.i [ prop.className "fas fa-align-right" ] ]
            ]
        ]
    ]
]"""
                        ]
                    ]
                    Html.p [ 
                        text.hasTextRight
                        prop.text "Note: Icon using Font Awesome."
                    ]             
                ]
    ]

let card =
    Html.div [  Bulma.title "Feliz.Bulma - Documentation"
                Bulma.subtitle "Card"
                Html.hr [] 
                Html.div [
                    Bulma.title "Basic"
                    Bulma.columns [
                        Bulma.column [
                            Bulma.card [
                                Bulma.cardImage [
                                    Bulma.image [
                                        Bulma.image.is4by3
                                        prop.children [
                                            Html.img [ 
                                                prop.alt "Placeholder image"
                                                prop.src "https://bulma.io/images/placeholders/1280x960.png"
                                            ]
                                        ]
                                    ]
                                ]
                                Bulma.cardContent [
                                    Bulma.media [
                                        Bulma.mediaLeft [
                                            Bulma.cardImage [
                                                Bulma.image [
                                                    Bulma.image.is48x48
                                                    prop.children [
                                                        Html.img [ 
                                                            prop.alt "Placeholder image"
                                                            prop.src "https://bulma.io/images/placeholders/96x96.png"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Bulma.mediaContent [
                                            Bulma.title.p [
                                                Bulma.title.is4
                                                prop.text "Feliz Bulma"
                                            ]
                                            Bulma.subtitle.p [
                                                Bulma.title.is6
                                                prop.text "@feliz.bulma"
                                            ]
                                        ]
                                    ]
                                    Bulma.content "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec iaculis mauris."
                                ]
                            ]
                        ]
                        Bulma.column [
                            code """Bulma.card [
    Bulma.cardImage [
        Bulma.image [
            Bulma.image.is4by3
            prop.children [
                Html.img [ 
                    prop.alt "Placeholder image"
                    prop.src "https://bulma.io/images/placeholders/1280x960.png"
                ]
            ]
        ]
    ]
    Bulma.cardContent [
        Bulma.media [
            Bulma.mediaLeft [
                Bulma.cardImage [
                    Bulma.image [
                        Bulma.image.is48x48
                        prop.children [
                            Html.img [ 
                                prop.alt "Placeholder image"
                                prop.src "https://bulma.io/images/placeholders/96x96.png"
                            ]
                        ]
                    ]
                ]
            ]
            Bulma.mediaContent [
                Bulma.title.p [
                    Bulma.title.is4
                    prop.text "Feliz Bulma"
                ]
                Bulma.subtitle.p [
                    Bulma.title.is6
                    prop.text "@feliz.bulma"
                ]
            ]
        ]
        Bulma.content "Lorem ipsum dolor sit ... nec iaculis mauris."
    ]
]"""
                        ]
                    ]
                ]
                Html.div [
                    Bulma.title "Card header"
                    Bulma.columns [
                        Bulma.column [
                            Bulma.card [
                                Bulma.cardHeader [
                                    Bulma.cardHeaderTitle.p "Card header"
                                    Bulma.cardHeaderIcon.span [ Html.i [prop.className "fas fa-angle-down"] ]
                                ]
                            ]
                        ]
                        Bulma.column [
                            code """ Bulma.card [
    Bulma.cardHeader [
        Bulma.cardHeaderTitle.p "Card header"
        Bulma.cardHeaderIcon.span [
            Html.i [prop.className "fas fa-angle-down"]
        ]
    ]
]"""
                        ]
                    ]
                ]
                Html.div [
                    Bulma.title "Card footer"
                    Bulma.columns [
                        Bulma.column [
                            Bulma.card [
                                Bulma.cardFooter [
                                    Bulma.cardFooterItem.a [
                                        prop.text "Save"
                                    ]
                                    Bulma.cardFooterItem.a [
                                        prop.text "Edit"
                                    ]
                                    Bulma.cardFooterItem.a [
                                        prop.text "Delete"
                                    ]
                                ]
                            ]
                        ]
                        Bulma.column [
                            code """Bulma.card [
    Bulma.cardFooter [
        Bulma.cardFooterItem.a [
            prop.text "Save"
        ]
        Bulma.cardFooterItem.a [
            prop.text "Edit"
        ]
        Bulma.cardFooterItem.a [
            prop.text "Delete"
        ]
    ]
]"""
                        ]
                    ]
                ]
    ]

let form =
     Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Form"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic login"
            Bulma.columns [
                Bulma.column [
                    Html.form [
                        Bulma.field.div [
                            Bulma.label "Username"
                            Bulma.control.div [
                                Bulma.input.text [
                                    prop.placeholder "nickname"
                                ]
                            ]
                        ]
                        Bulma.field.div [
                            Bulma.label "Password"
                            Bulma.control.div [
                                Bulma.input.password [
                                    prop.placeholder "*****"
                                ]
                            ]
                        ]
                        Bulma.field.div [
                            Bulma.field.isGrouped
                            Bulma.field.isGroupedCentered
                            prop.children [
                                Bulma.control.div [
                                    Bulma.button.a [
                                        Bulma.color.isLink
                                        prop.text "Submit"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    code """Html.form [
    Bulma.field.div [
        Bulma.label "Username"
        Bulma.control.div [
            Bulma.input.text [
                prop.placeholder "nickname"
            ]
        ]
    ]
    Bulma.field.div [
        Bulma.label "Password"
        Bulma.control.div [
            Bulma.input.password [
                prop.placeholder "*****"
            ]
        ]
    ]
    Bulma.field.div [
        Bulma.field.isGrouped
        Bulma.field.isGroupedCentered
        prop.children [
            Bulma.control.div [
                Bulma.button.button [
                    Bulma.color.isLink
                    prop.text "Submit"
                ]
            ]
        ]
    ]
]"""
                ]
            ]
        ]
        Bulma.content [
            Bulma.title "Form field"
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label"
                        Bulma.control.div [
                            Bulma.input.text [
                                prop.required true
                                prop.placeholder "Placeholder"
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    code """Bulma.field.div [
    Bulma.label "Label"
    Bulma.control.div [
        Bulma.input.text [
            prop.required true
            prop.placeholder "Placeholder"
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label with help"
                        Bulma.control.div [
                            Bulma.input.text [
                                prop.required true
                                prop.placeholder "Placeholder"
                            ]
                        ]
                        Bulma.help "This is a help text"
                    ]
                ]
                Bulma.column [
                    code """Bulma.field.div [
    Bulma.label "Label with help"
    Bulma.control.div [
        Bulma.input.text [
            prop.required true
            prop.placeholder "Placeholder"
        ]
    ]
    Bulma.help "This is a help text"
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label with left icon"
                        Bulma.control.p [
                            Bulma.control.hasIconsLeft
                            prop.children [
                                Bulma.input.text [
                                    prop.required true
                                    prop.placeholder "Placeholder with left icon"
                                ]
                                Bulma.icon [
                                    Bulma.icon.isSmall
                                    Bulma.icon.isLeft
                                    prop.children [
                                        Html.i [
                                            prop.className "fas fa-envelope"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    code """Bulma.field.div [
    Bulma.label "Label with left icon"
    Bulma.control.p [
        Bulma.control.hasIconsLeft
        prop.children [
            Bulma.input.text [
                prop.required true
                prop.placeholder "Placeholder with left icon"
            ]
            Bulma.icon [
                Bulma.icon.isSmall
                Bulma.icon.isLeft
                prop.children [
                    Html.i [
                        prop.className "fas fa-envelope"
                    ]
                ]
            ]
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label with right icon"
                        Bulma.control.p [
                            Bulma.control.hasIconsRight
                            prop.children [
                                Bulma.input.text [
                                    prop.required true
                                    prop.placeholder "Placeholder with right icon"
                                ]
                                Bulma.icon [
                                    Bulma.icon.isSmall
                                    Bulma.icon.isRight
                                    prop.children [
                                        Html.i [
                                            prop.className "fas fa-check"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    code """Bulma.field.div [
    Bulma.label "Label with right icon"
    Bulma.control.p [
        Bulma.control.hasIconsRight
        prop.children [
            Bulma.input.text [
                prop.required true
                prop.placeholder "Placeholder with right icon"
            ]
            Bulma.icon [
                Bulma.icon.isSmall
                Bulma.icon.isRight
                prop.children [
                    Html.i [
                        prop.className "fas fa-check"
                    ]
                ]
            ]
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Dropdown"
                        Bulma.control.p [
                            Bulma.control.hasIconsLeft
                            prop.children [
                                Bulma.select [
                                    Html.option "Country"
                                    Html.option "Select dropdown"
                                    Html.option "With options"
                                ]
                                Bulma.icon [
                                    Bulma.icon.isSmall
                                    Bulma.icon.isLeft
                                    prop.children [
                                        Html.i [
                                            prop.className "fas fa-globe"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    code """Bulma.field.div [
    Bulma.label "Dropdown"
    Bulma.control.p [
        Bulma.control.hasIconsLeft
        prop.children [
            Bulma.select [
                Html.option "Country"
                Html.option "Select dropdown"
                Html.option "With options"
            ]
            Bulma.icon [
                Bulma.icon.isSmall
                Bulma.icon.isLeft
                prop.children [
                    Html.i [
                        prop.className "fas fa-globe"
                    ]
                ]
            ]
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label [
                            Bulma.input.checkbox [ prop.value "remember" ]
                            Bulma.text.span "Remember me" // ToDo - need a element like <>Remember me</>
                        ]
                    ]
                ]
                Bulma.column [
                    code """Bulma.field.div [
    Bulma.label [
        Bulma.input.checkbox [ prop.value "remember" ]
        Bulma.text.span "Remember me" // ToDo - need a element like <>Remember me</>
    ]
]"""
                ]
            ]

            Bulma.columns [
                Bulma.column [
                    Bulma.control.div [
                        Bulma.input.labels.radio [
                            prop.children [
                                Bulma.input.radio [
                                    prop.name "options"
                                    prop.value "1"
                                ]
                                Bulma.text.span "Option 1" // ToDo - need a element like <>Remember me</>
                            ]
                        ]
                        Bulma.input.labels.radio [
                            prop.children [
                                Bulma.input.radio [
                                    prop.name "options"
                                    prop.value "2"
                                ]
                                Bulma.text.span "Option 2" // ToDo - need a element like <>Remember me</>
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    code """Bulma.input.labels.radio [
        prop.children [
            Bulma.input.radio [
                prop.name "options"
                prop.value "1"
            ]
            Bulma.text.span "Option 1" // ToDo - need a element like <>Remember me</>
        ]
    ]
    Bulma.input.labels.radio [
        prop.children [
            Bulma.input.radio [
                prop.name "options"
                prop.value "2"
            ]
            Bulma.text.span "Option 2" // ToDo - need a element like <>Remember me</>
        ]
    ]
]"""
                ]
            ]
        ]
     ]

let mediaObject = 
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Media Object"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic"
            Bulma.columns [
                Bulma.column [
                    Bulma.column.isHalf
                    prop.children [
                        Bulma.media [
                            Bulma.mediaLeft [
                                Bulma.image [
                                    Bulma.image.is64x64
                                    prop.children[
                                        Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
                                    ]
                                ]
                            ]
                            Bulma.mediaContent [
                                Bulma.content [
                                    Html.p [
                                        Html.strong "John Smith"
                                        Html.small "@johnsmith"
                                        Html.br []
                                        Html.span "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare magna eros, eu pellentesque tortor vestibulum ut." 
                                    ]
                                ]
                                Bulma.level [
                                    Bulma.levelLeft [
                                        Bulma.levelItem [
                                            Bulma.icon [
                                                Bulma.icon.isSmall
                                                prop.children [ Html.i [ prop.className "fas fa-reply" ] ]
                                            ]
                                        ]
                                        Bulma.levelItem [
                                            Bulma.icon [
                                                Bulma.icon.isSmall
                                                prop.children [ Html.i [ prop.className "fas fa-retweet" ] ]
                                            ]
                                        ]
                                        Bulma.levelItem [
                                            Bulma.icon [
                                                Bulma.icon.isSmall
                                                prop.children [ Html.i [ prop.className "fas fa-heart" ] ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Bulma.column.isHalf
                    prop.children [
                        code """Bulma.media [
    Bulma.mediaLeft [
        Bulma.image [
            Bulma.image.is64x64
            prop.children[
                Html.img [
                    prop.src "https://bulma.io/images/placeholders/128x128.png"
                ]
            ]
        ]
    ]
    Bulma.mediaContent [
        Bulma.content [
            Html.p [
                Html.strong "John Smith"
                Html.small "@johnsmith"
                Html.br []
                Html.span "Lorem ipsum ... vestibulum ut." 
            ]
        ]
        Bulma.level [
            Bulma.levelLeft [
                Bulma.levelItem [
                    Bulma.icon [
                        Bulma.icon.isSmall
                        prop.children [
                            Html.i [ prop.className "fas fa-reply" ]
                        ]
                    ]
                ]
                Bulma.levelItem [
                    Bulma.icon [
                        Bulma.icon.isSmall
                        prop.children [
                            Html.i [ prop.className "fas fa-retweet" ]
                        ]
                    ]
                ]
                Bulma.levelItem [
                    Bulma.icon [
                        Bulma.icon.isSmall
                        prop.children [
                            Html.i [ prop.className "fas fa-heart" ]
                        ]
                    ]
                ]
            ]
        ]
    ]
]"""
                    ]
                ]
            ]
        ]
        Bulma.content [
            Bulma.title "Nesting"
            Bulma.subtitle.h5 [
                prop.text "You can nest media objects up to 3 levels deep."
            ]
            Bulma.media [
                Bulma.mediaLeft [
                    Bulma.image [
                        Bulma.image.is64x64
                        prop.children[
                            Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
                        ]
                    ]
                ]
                Bulma.mediaContent [
                    Bulma.content [
                        Html.p [
                            Html.strong "Barbara Middleton"
                            Html.br []
                            Html.span "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare magna eros, eu pellentesque tortor vestibulum ut." 
                            Html.br []
                            Html.small [
                                Html.a [ prop.text "Like"]
                                Html.span " · "
                                Html.a [ prop.text "Reply" ]
                                Html.span " · "
                                Html.span "3hrs ago"
                            ]
                        ]
                    ]
                    Bulma.media [
                        Bulma.mediaLeft [
                            Bulma.image [
                                Bulma.image.is64x64
                                prop.children[
                                    Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
                                ]
                            ]
                        ]
                        Bulma.mediaContent [
                            Bulma.content [
                                Html.p [
                                    Html.strong "Sean Brown"
                                    Html.br []
                                    Html.span "Donec sollicitudin urna eget eros malesuada sagittis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam blandit nisl a nulla sagittis, a lobortis leo feugiat." 
                                    Html.br []
                                    Html.small [
                                        Html.a [ prop.text "Like"]
                                        Html.span " · "
                                        Html.a [ prop.text "Reply" ]
                                        Html.span " · "
                                        Html.span "3hrs ago"
                                    ]
                                ]
                            ]
                        ]
                    ]
                    Bulma.media [
                        Bulma.mediaLeft [
                            Bulma.image [
                                Bulma.image.is64x64
                                prop.children[
                                    Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
                                ]
                            ]
                        ]
                        Bulma.mediaContent [
                            Bulma.content [
                                Html.p [
                                    Html.strong "Kayli Eunice"
                                    Html.br []
                                    Html.span "Sed convallis scelerisque mauris, non pulvinar nunc mattis vel. Maecenas varius felis sit amet magna vestibulum euismod malesuada cursus libero." 
                                    Html.br []
                                    Html.small [
                                        Html.a [ prop.text "Like"]
                                        Html.span " · "
                                        Html.a [ prop.text "Reply" ]
                                        Html.span " · "
                                        Html.span "3hrs ago"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
            Bulma.media [
                Bulma.mediaLeft [
                    Bulma.image [
                        Bulma.image.is64x64
                        prop.children[
                            Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
                        ]
                    ]
                ]
                Bulma.mediaContent [
                    Bulma.field.div [
                        Bulma.control.p [
                            Bulma.textarea [ prop.placeholder "Add a comment..."]
                        ]
                    ]
                    Bulma.field.div [
                        Bulma.control.p [
                            Bulma.button.button [ prop.text "Post comment" ]
                        ]
                    ]
                ]
            ]
            code """Bulma.media [
    Bulma.mediaLeft [
        Bulma.image [
            Bulma.image.is64x64
            prop.children[
                Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
            ]
        ]
    ]
    Bulma.mediaContent [
        Bulma.content [
            Html.p [
                Html.strong "Barbara Middleton"
                Html.br []
                Html.span "Lorem ipsum dolor sit ... vestibulum ut." 
                Html.br []
                Html.small [
                    Html.a [ prop.text "Like"]
                    Html.span " · "
                    Html.a [ prop.text "Reply" ]
                    Html.span " · "
                    Html.span "3hrs ago"
                ]
            ]
        ]
        Bulma.media [
            Bulma.mediaLeft [
                Bulma.image [
                    Bulma.image.is64x64
                    prop.children[
                        Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
                    ]
                ]
            ]
            Bulma.mediaContent [
                Bulma.content [
                    Html.p [
                        Html.strong "Sean Brown"
                        Html.br []
                        Html.span "Donec sollicitudin urna ... leo feugiat." 
                        Html.br []
                        Html.small [
                            Html.a [ prop.text "Like"]
                            Html.span " · "
                            Html.a [ prop.text "Reply" ]
                            Html.span " · "
                            Html.span "3hrs ago"
                        ]
                    ]
                ]
            ]
        ]
        Bulma.media [
            Bulma.mediaLeft [
                Bulma.image [
                    Bulma.image.is64x64
                    prop.children[
                        Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
                    ]
                ]
            ]
            Bulma.mediaContent [
                Bulma.content [
                    Html.p [
                        Html.strong "Kayli Eunice"
                        Html.br []
                        Html.span "Sed convallis scelerisque ... cursus libero." 
                        Html.br []
                        Html.small [
                            Html.a [ prop.text "Like"]
                            Html.span " · "
                            Html.a [ prop.text "Reply" ]
                            Html.span " · "
                            Html.span "3hrs ago"
                        ]
                    ]
                ]
            ]
        ]
    ]
]
Bulma.media [
    Bulma.mediaLeft [
        Bulma.image [
            Bulma.image.is64x64
            prop.children[
                Html.img [ prop.src "https://bulma.io/images/placeholders/128x128.png" ]
            ]
        ]
    ]
    Bulma.mediaContent [
        Bulma.field.div [
            Bulma.control.p [
                Bulma.textarea [ prop.placeholder "Add a comment..."]
            ]
        ]
        Bulma.field.div [
            Bulma.control.p [
                Bulma.button.button [ prop.text "Post comment" ]
            ]
        ]
    ]
]"""
        ]
    ]

[<ReactComponent>]
let modalComponent () = 
    let modalState, toggleState = React.useState(false)
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Modal"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic"
            Bulma.columns [
                Bulma.column [
                    Bulma.button.button [
                        prop.ariaHasPopup true
                        prop.target "modal-sample"
                        prop.text "Launch example modal"
                        prop.onClick (fun _ -> toggleState(true))
                    ]
                    Bulma.modal [
                        prop.id "modal-sample"
                        if modalState then Bulma.modal.isActive
                        prop.children [
                            Bulma.modalBackground []
                            Bulma.modalContent [
                                Bulma.box [
                                    Html.h1 "Modal content"
                                ]
                            ]
                            Bulma.modalClose [ prop.onClick (fun _ -> toggleState(false))]
                        ]
                    ]
                ]
                Bulma.column [
                    code """let modalState, toggleState = React.useState(false)

Bulma.button.button [
    prop.ariaHasPopup true
    prop.target "modal-sample"
    prop.text "Launch example modal"
    prop.onClick (fun _ -> toggleState(true))
]
Bulma.modal [
    prop.id "modal-sample"
    if modalState then Bulma.modal.isActive
    prop.children [
        Bulma.modalBackground []
        Bulma.modalContent [
            Bulma.box [
                Html.h1 "Modal content"
            ]
        ]
        Bulma.modalClose [ prop.onClick (fun _ -> toggleState(false))]
    ]
]"""
                ]
            ]
        ]
    ]
let modal = 
    modalComponent()

[<ReactComponent>]
let navbarComponent () =
    let color, chooseColor = React.useState(Primary)
    
    let getColorChooseButtonToNavbar (color: Color) = getColorChooseButton color chooseColor

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Navbar"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic navbar"

            Bulma.navbar [
                Bulma.navbarBrand.div [
                    Bulma.navbarItem.a [
                        Html.img [ prop.src "https://bulma.io/images/bulma-logo.png"; prop.height 28; prop.width 112; ]
                    ]
                    Bulma.navbarBurger [
                        Html.span [ prop.ariaHidden true ]
                    ]
                ]
                Bulma.navbarMenu [
                    Bulma.navbarStart.div [
                        Bulma.navbarItem.a [ prop.text "Home" ]
                        Bulma.navbarItem.a [ prop.text "Documentation" ]
                        Bulma.navbarItem.div [
                            Bulma.navbarItem.hasDropdown
                            Bulma.navbarItem.isHoverable
                            prop.children [
                                Bulma.navbarLink.a [ prop.text "More" ]
                                Bulma.navbarDropdown.div [
                                    Bulma.navbarItem.a [ prop.text "About" ]
                                    Bulma.navbarItem.a [ prop.text "Jobs" ]
                                    Bulma.navbarItem.a [ prop.text "Contact" ]
                                    Bulma.navbarDivider []
                                    Bulma.navbarItem.a [ prop.text "Report an issue" ]
                                ]
                            ]
                        ]
                    ]
                    Bulma.navbarEnd.div [
                        Bulma.navbarItem.div [
                            Bulma.buttons [
                                Bulma.button.a [
                                    Bulma.color.isPrimary
                                    prop.children [
                                        Html.strong "Sign up"
                                    ]
                                ]
                                Bulma.button.a [ prop.text "Log In" ]
                            ]
                        ]
                    ]
                ]
            ]
            code """Bulma.navbarMenu [
    Bulma.navbarStart.div [
        Bulma.navbarItem.a [ prop.text "Home" ]
        Bulma.navbarItem.a [ prop.text "Documentation" ]
        Bulma.navbarItem.div [
            Bulma.navbarItem.hasDropdown
            Bulma.navbarItem.isHoverable
            prop.children [
                Bulma.navbarLink.a [ prop.text "More" ]
                Bulma.navbarDropdown.div [
                    Bulma.navbarItem.a [ prop.text "About" ]
                    Bulma.navbarItem.a [ prop.text "Jobs" ]
                    Bulma.navbarItem.a [ prop.text "Contact" ]
                    Bulma.navbarDivider []
                    Bulma.navbarItem.a [ prop.text "Report a issue" ]
                ]
            ]
        ]
    ]
    Bulma.navbarEnd.div [
        Bulma.navbarItem.div [
            Bulma.buttons [
                Bulma.button.a [
                    Bulma.color.isPrimary
                    prop.children [
                        Html.strong "Sign up"
                    ]
                ]
                Bulma.button.a [ prop.text "Log In" ]
            ]
        ]
    ]
]"""
            
            Bulma.title "Colors"
            Bulma.box [
                Bulma.subtitle [ prop.text "Choose a color:" ]
                Bulma.buttons [
                    getColorChooseButtonToNavbar Primary
                    getColorChooseButtonToNavbar Danger
                    getColorChooseButtonToNavbar Info
                    getColorChooseButtonToNavbar Link
                    getColorChooseButtonToNavbar Success
                    getColorChooseButtonToNavbar Warning
                    getColorChooseButtonToNavbar Black
                    getColorChooseButtonToNavbar Dark
                    getColorChooseButtonToNavbar Light
                    getColorChooseButtonToNavbar White
                ]
                Bulma.subtitle [
                    Bulma.text.hasTextWeightLight
                    prop.text "Navbar with links"
                ]
                Bulma.navbar [
                    getColorInfo(color).PropertyName
                    prop.children [
                        Bulma.navbarBrand.div [
                            Bulma.navbarItem.a [
                                Html.img [ prop.src "https://bulma.io/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
                            ]
                        ]
                        Bulma.navbarMenu [
                            Bulma.navbarStart.div [
                                Bulma.navbarItem.a [ prop.text "Home" ]
                                Bulma.navbarItem.a [ prop.text "Documentation" ]
                                Bulma.navbarItem.a [ prop.text "Jobs" ]
                                Bulma.navbarItem.a [ prop.text "Contact" ]
                                Bulma.navbarItem.a [ prop.text "About" ]
                            ]
                        ]
                    ]
                ]
                code $"""Bulma.navbar [
    Bulma.color.is{getColorInfo(color).Name}
    prop.children [
        Bulma.navbarBrand.div [
            Bulma.navbarItem.a [
                Html.img [ prop.src "https://bulma.io/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
            ]
        ]
        Bulma.navbarMenu [
            Bulma.navbarStart.div [
                Bulma.navbarItem.a [ prop.text "Home" ]
                Bulma.navbarItem.a [ prop.text "Documentation" ]
                Bulma.navbarItem.a [ prop.text "Jobs" ]
                Bulma.navbarItem.a [ prop.text "Contact" ]
                Bulma.navbarItem.a [ prop.text "About" ]
            ]
        ]
    ]
]"""
                Bulma.subtitle [
                    Bulma.text.hasTextWeightLight
                    prop.text "Navbar with item Start + End"
                ]
                Bulma.navbar [
                    getColorInfo(color).PropertyName
                    prop.children [
                        Bulma.navbarBrand.div [
                            Bulma.navbarItem.a [
                                Html.img [ prop.src "https://bulma.io/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
                            ]
                        ]
                        Bulma.navbarMenu [
                            Bulma.navbarStart.div [
                                Bulma.navbarItem.a [ prop.text "Home" ]
                                Bulma.navbarItem.a [ prop.text "Documentation" ]
                                Bulma.navbarItem.a [ prop.text "Jobs" ]
                            ]
                            Bulma.navbarEnd.div [
                                Bulma.navbarItem.div [
                                    Bulma.buttons [
                                        Bulma.button.a [ Html.strong "Sign up" ]
                                        Bulma.button.a [ prop.text "Log In" ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                code $"""Bulma.navbar [
    Bulma.color.is{getColorInfo(color).Name}
    prop.children [
        Bulma.navbarBrand.div [
            Bulma.navbarItem.a [
                Html.img [ prop.src "https://bulma.io/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
            ]
        ]
        Bulma.navbarMenu [
            Bulma.navbarStart.div [
                Bulma.navbarItem.a [ prop.text "Home" ]
                Bulma.navbarItem.a [ prop.text "Documentation" ]
                Bulma.navbarItem.a [ prop.text "Jobs" ]
            ]
            Bulma.navbarEnd.div [
                Bulma.navbarItem.div [
                    Bulma.buttons [
                        Bulma.button.a [ Html.strong "Sign up" ]
                        Bulma.button.a [ prop.text "Log In" ]
                    ]
                ]
            ]
        ]
    ]
]"""
                Bulma.subtitle [
                    Bulma.text.hasTextWeightLight
                    prop.text "Navbar with search and end item (user)"
                ]
                Bulma.navbar [
                    getColorInfo(color).PropertyName
                    prop.children [
                        Bulma.navbarBrand.div [
                            Bulma.navbarItem.a [
                                Html.img [ prop.src "https://bulma.io/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
                            ]
                        ]
                        Bulma.navbarMenu [
                            Bulma.navbarStart.div [
                                Bulma.navbarItem.a [ prop.text "Home" ]
                                Bulma.navbarItem.a [ prop.text "Documentation" ]
                                Bulma.navbarItem.div [
                                    Bulma.control.p [
                                        Bulma.control.hasIconsRight
                                        prop.children [
                                            Bulma.input.text [
                                                prop.required true
                                                prop.placeholder "Search in navbar"
                                            ]
                                            Bulma.icon [
                                                Bulma.icon.isSmall
                                                Bulma.icon.isRight
                                                prop.children [
                                                    Html.i [ prop.className "fas fa-search" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Bulma.navbarEnd.div [
                                Bulma.navbarItem.div [
                                    Bulma.media [
                                        Bulma.mediaContent [
                                            Bulma.text.hasTextRight
                                            prop.children [
                                                Bulma.title.p [
                                                    Bulma.text.hasTextWeightBold
                                                    Bulma.title.is6
                                                    prop.text "Feliz Bulma"
                                                ]
                                                Bulma.subtitle.p [
                                                    Bulma.title.is6
                                                    Bulma.text.hasTextWeightLight
                                                    Bulma.color.hasTextGreyLighter
                                                    prop.text "@feliz.bulma"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                code $"""Bulma.navbar [
    Bulma.color.is{getColorInfo(color).Name}
    prop.children [
        Bulma.navbarBrand.div [
            Bulma.navbarItem.a [
                Html.img [ prop.src "https://bulma.io/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
            ]
        ]
        Bulma.navbarMenu [
            Bulma.navbarStart.div [
                Bulma.navbarItem.a [ prop.text "Home" ]
                Bulma.navbarItem.a [ prop.text "Documentation" ]
                Bulma.navbarItem.div [
                    Bulma.control.p [
                        Bulma.control.hasIconsRight
                        prop.children [
                            Bulma.input.text [
                                prop.required true
                                prop.placeholder "Search in navbar"
                            ]
                            Bulma.icon [
                                Bulma.icon.isSmall
                                Bulma.icon.isRight
                                prop.children [
                                    Html.i [ prop.className "fas fa-search" ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
            Bulma.navbarEnd.div [
                Bulma.navbarItem.div [
                    Bulma.media [
                        Bulma.mediaContent [
                            Bulma.text.hasTextRight
                            prop.children [
                                Bulma.title.p [
                                    Bulma.text.hasTextWeightBold
                                    Bulma.title.is6
                                    prop.text "Feliz Bulma"
                                ]
                                Bulma.subtitle.p [
                                    Bulma.title.is6
                                    Bulma.text.hasTextWeightLight
                                    Bulma.color.hasTextGreyLighter
                                    prop.text "@feliz.bulma"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
]"""
            ]
        ]
    ]

let navbar =
    navbarComponent()

[<ReactComponent>]
let progressbarComponent () =
    let color, chooseColor = React.useState(Primary)
    let getColorChooseButtonToProgressBar (color: Color) = getColorChooseButton color chooseColor

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Progress Bar"
        Html.hr []
        Bulma.content [
            Bulma.subtitle [ prop.text "Choose a color:" ]
            Bulma.buttons [
                getColorChooseButtonToProgressBar Primary
                getColorChooseButtonToProgressBar Danger
                getColorChooseButtonToProgressBar Info
                getColorChooseButtonToProgressBar Link
                getColorChooseButtonToProgressBar Success
                getColorChooseButtonToProgressBar Warning
                getColorChooseButtonToProgressBar Black
                getColorChooseButtonToProgressBar Dark
                getColorChooseButtonToProgressBar Light
                getColorChooseButtonToProgressBar White
            ]
            Bulma.subtitle [
                Bulma.text.hasTextWeightLight
                prop.text "Basic"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        getColorInfo(color).PropertyName
                        prop.value 50
                        prop.max 100
                    ]
                ]
                Bulma.column [ code $"""Bulma.progress [
    Bulma.color.is{getColorInfo(color).Name}
    prop.value 50
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                Bulma.text.hasTextWeightLight
                prop.text "Small"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        getColorInfo(color).PropertyName
                        Bulma.progress.isSmall
                        prop.value 15
                        prop.max 100
                    ]
                ]
                Bulma.column [ code $"""Bulma.progress [
    Bulma.color.is{getColorInfo(color).Name}
    Bulma.progress.isSmall
    prop.value 15
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                Bulma.text.hasTextWeightLight
                prop.text "Medium"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        getColorInfo(color).PropertyName
                        Bulma.progress.isMedium
                        prop.value 45
                        prop.max 100
                    ]
                ]
                Bulma.column [ code $"""Bulma.progress [
    Bulma.color.is{getColorInfo(color).Name}
    Bulma.progress.isMedium
    prop.value 45
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                Bulma.text.hasTextWeightLight
                prop.text "Large"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        getColorInfo(color).PropertyName
                        Bulma.progress.isLarge
                        prop.value 75
                        prop.max 100
                    ]
                ]
                Bulma.column [ code $"""Bulma.progress [
    Bulma.color.is{getColorInfo(color).Name}
    Bulma.progress.isLarge
    prop.value 75
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                Bulma.text.hasTextWeightLight
                prop.text "Indeterminate"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        getColorInfo(color).PropertyName
                        prop.max 100
                    ]
                ]
                Bulma.column [ code $"""Bulma.column [
    Bulma.progress [
        Bulma.color.is{getColorInfo(color).Name}
        prop.max 100
    ]
]"""
                ]
            ]
        ]
    ]

let progressbar = 
    progressbarComponent()

[<ReactComponent>]
let tagComponent () = 
    let color, chooseColor = React.useState(Primary)
    let getColorChooseButtonToTag (color: Color) = getColorChooseButton color chooseColor

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Tag"
        Html.hr []
        Bulma.content [
            Bulma.subtitle [ prop.text "Choose a color:" ]
            Bulma.buttons [
                getColorChooseButtonToTag Primary
                getColorChooseButtonToTag Danger
                getColorChooseButtonToTag Info
                getColorChooseButtonToTag Link
                getColorChooseButtonToTag Success
                getColorChooseButtonToTag Warning
                getColorChooseButtonToTag Black
                getColorChooseButtonToTag Dark
                getColorChooseButtonToTag Light
                getColorChooseButtonToTag White
            ]
            Bulma.subtitle [
                Bulma.text.hasTextWeightLight
                prop.text "Basic"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [ getColorInfo(color).PropertyName; prop.text $"Tag basic"; ]
                ]
                Bulma.column [
                    code $"""Bulma.tag [
    Bulma.color.is{getColorInfo(color).Name}
    prop.text "Tag basic" 
]"""
                ]
            ]
            Bulma.subtitle [
                Bulma.text.hasTextWeightLight
                prop.text "Light"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [ getColorInfo(color).PropertyName; Bulma.color.isLight; prop.text "Tag light"; ]
                ]
                Bulma.column [
                    code $"""Bulma.tag [
    Bulma.color.is{getColorInfo(color).Name}
    Bulma.color.isLight
    prop.text "Tag light" 
]"""
                ]
            ]
            Bulma.subtitle [ Bulma.text.hasTextWeightLight; prop.text "Size medium"; ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [ getColorInfo(color).PropertyName; Bulma.tag.isMedium; prop.text "Tag medium"; ]
                ]
                Bulma.column [
                    code $"""Bulma.tag [
    Bulma.color.is{getColorInfo(color).Name}
    Bulma.tag.isMedium
    prop.text "Tag medium" 
]"""
                ]
            ]
            Bulma.subtitle [ Bulma.text.hasTextWeightLight; prop.text "Size large"; ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [ getColorInfo(color).PropertyName; Bulma.tag.isLarge; prop.text "Tag large"; ]
                ]
                Bulma.column [
                    code $"""Bulma.tag [
    Bulma.color.is{getColorInfo(color).Name}
    Bulma.tag.isLarge
    prop.text "Tag large" 
]"""
                ]
            ]
            Bulma.subtitle [ Bulma.text.hasTextWeightLight; prop.text "Rounded"; ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [ getColorInfo(color).PropertyName; Bulma.tag.isRounded; prop.text "Tag rounded"; ]
                ]
                Bulma.column [
                    code $"""Bulma.tag [
    Bulma.color.is{getColorInfo(color).Name}
    Bulma.tag.isRounded
    prop.text "Tag rounded" 
]"""
                ]
            ]
            Bulma.subtitle [ Bulma.text.hasTextWeightLight; prop.text "List of tags"; ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tags [
                        Bulma.tag [ getColorInfo(color).PropertyName; prop.text "One"; ]
                        Bulma.tag [ getColorInfo(color).PropertyName; prop.text "Two"; ]
                        Bulma.tag [ getColorInfo(color).PropertyName; prop.text "Three"; ]
                    ]
                ]
                Bulma.column [
                    code $"""Bulma.column [
    Bulma.tags [
        Bulma.tag [
            Bulma.color.is{getColorInfo(color).Name}
            prop.text "One"
        ]
        Bulma.tag [
            Bulma.color.is{getColorInfo(color).Name}
            prop.text "Two"
        ]
        Bulma.tag [
            Bulma.color.is{getColorInfo(color).Name}
            prop.text "Three"
        ]
    ]
]"""
                ]
            ]
            Bulma.subtitle [ Bulma.text.hasTextWeightLight; prop.text "Tag addons"; ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tags [
                        Bulma.tags.hasAddons
                        prop.children [
                            Bulma.tag "Package"
                            Bulma.tag [ getColorInfo(color).PropertyName; prop.text "Feliz.Bulma"; ]
                        ]
                    ]
                ]
                Bulma.column [
                    code $"""Bulma.tags [
    Bulma.tags.hasAddons
    prop.children [
        Bulma.tag "Package"
        Bulma.tag [
            Bulma.color.is{getColorInfo(color).Name}
            prop.text "Feliz.Bulma"
        ]
    ]
]"""
                ]
            ]
            Bulma.subtitle [ Bulma.text.hasTextWeightLight; prop.text "Tag with delete"; ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tags [
                        Bulma.tags.hasAddons
                        prop.children [
                            Bulma.tag [ getColorInfo(color).PropertyName; prop.text "Feliz.Bulma"]
                            Bulma.tag [ Bulma.tag.isDelete ]
                        ]
                    ]
                ]
                Bulma.column [
                    code $"""Bulma.tags [
    Bulma.tags.hasAddons
    prop.children [
        Bulma.tag [
            Bulma.color.is{getColorInfo(color).Name}
            prop.text "Feliz.Bulma"
        ]
        Bulma.tag [ Bulma.tag.isDelete ]
    ]
]"""
                ]
            ]
        ]
    ]

let tag = 
    tagComponent()