module Docs.Views.Documentation

open Feliz
open Feliz.Bulma
open Shared

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