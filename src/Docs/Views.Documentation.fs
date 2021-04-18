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

type navbarColorType = { Type: Color; Name: string; PropertyName: IReactProperty; }

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

open Docs.State
open Microsoft.FSharp.Reflection

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
    
    let navbarColor = function
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

    let inline getNavbarColor (color: Color) = 
        Bulma.button.button [ navbarColor(color).PropertyName; prop.text(navbarColor(color).Name); prop.onClick (fun _ -> chooseColor(color)); ]

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
                    getNavbarColor(Primary)
                    getNavbarColor(Danger)
                    getNavbarColor(Info)
                    getNavbarColor(Link)
                    getNavbarColor(Success)
                    getNavbarColor(Warning)
                    getNavbarColor(Black)
                    getNavbarColor(Dark)
                    getNavbarColor(Light)
                    getNavbarColor(White)
                ]
                Bulma.subtitle [
                    Bulma.text.hasTextWeightLight
                    prop.text "Navbar with links"
                ]
                Bulma.navbar [
                    navbarColor(color).PropertyName
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
    Bulma.color.is{navbarColor(color).Name}
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
                    navbarColor(color).PropertyName
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
    Bulma.color.is{navbarColor(color).Name}
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
                    navbarColor(color).PropertyName
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
    Bulma.color.is{navbarColor(color).Name}
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