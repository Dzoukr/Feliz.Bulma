module Docs.Views.TagsInput

open Feliz
open Feliz.Bulma
open Shared

[<ReactComponent>]
let Description() =
    let myValue,setMyValue = React.useState(["default";"tags"])

    [
        Bulma.content [
            Bulma.title.h5 "Basic tag input"
            Html.p "Basic tag input can be created using code below."
            code """TagsInput.input [
    tagsInput.defaultValue [ "Some"; "Tags" ]
    tagsInput.onTagsChanged (fun x -> Fable.Core.JS.console.log(x))
]
"""
            TagsInput.input [
                tagsInput.defaultValue [ "Some"; "Tags" ]
                tagsInput.onTagsChanged (fun x -> Fable.Core.JS.console.log(x))
            ] |> Bulma.block
        ]
        Bulma.content [
            Bulma.title.h5 "Custom autocomplete"
            Html.p "Use async function for getting autocomplete values in dropdown."
            code """TagsInput.input [
    tagsInput.placeholder "Click on me to see async loading"
    tagsInput.autoCompleteSource (
        (fun text ->
            async {
                do! Async.Sleep 1000
                return ["A";"B";"C"] |> List.filter (fun x -> x.Contains(text))
            }
        )
    )
]
"""
            TagsInput.input [
                tagsInput.placeholder "Click on me to see async loading"
                tagsInput.autoCompleteSource (
                    (fun text ->
                        async {
                            do! Async.Sleep 1000
                            return ["A";"B";"C"] |> List.filter (fun x -> x.Contains(text))
                        }
                    )
                )
            ]
        ]
        Bulma.content [
            Bulma.title.h5 "Use own delimiter"
            Html.p "The default delimited is comma (\",\"), but you can use whatever char you need."
            code """TagsInput.input [
    tagsInput.delimiter '.'
    tagsInput.placeholder "Write some tag and press . for making cool tag"
]
"""
            TagsInput.input [
                tagsInput.delimiter '.'
                tagsInput.placeholder "Write some text and press . for making cool tag"
            ]
        ]
        Bulma.content [
            Bulma.title.h5 "Styling"
            Html.p "TagInput plays nicely with Feliz.Bulma properties"
            code """TagsInput.input [
    tagsInput.tagProperties [
        tag.isLarge
        color.isSuccess
    ]
    tagsInput.defaultValue [ "So"; "Cool!" ]
]
"""
            TagsInput.input [
                tagsInput.tagProperties [
                    tag.isLarge
                    color.isSuccess
                ]
                tagsInput.defaultValue [ "So"; "Cool!" ]
            ]
        ]
        Bulma.content [
            Bulma.title.h5 "...and much more!"
            Html.p "Play with tagsInput properties to see more cool stuff!"
            code """TagsInput.input [
    tagsInput.autoCompleteSource (fun _ -> ["Hello"; "FSharp"; "People"] |> async.Return)
    tagsInput.defaultValue [ "Default"; "Tags" ]
    tagsInput.noResultsLabel "Oh no... Nothing found!"
    tagsInput.loadingLabel "Monkeys are searching now..."
    tagsInput.delimiter ';'
    tagsInput.placeholder "Write here but cannot remove, ha!"
    tagsInput.allowDuplicates false
    tagsInput.caseSensitive false
    tagsInput.closeDropdownOnItemSelect false
    tagsInput.tagsRemovable false
    tagsInput.tagProperties [ tag.isRounded; color.isWarning ]
    tagsInput.autoTrim true
    tagsInput.removeSelectedFromAutoComplete true
    tagsInput.allowOnlyAutoCompleteValues false
    tagsInput.maxTags 10
]
"""
            TagsInput.input [
                tagsInput.autoCompleteSource (fun _ -> ["Hello"; "FSharp"; "People"] |> async.Return)
                tagsInput.defaultValue [ "Default"; "Tags" ]
                tagsInput.noResultsLabel "Oh no... Nothing found!"
                tagsInput.loadingLabel "Monkeys are searching now..."
                tagsInput.delimiter ';'
                tagsInput.placeholder "Write here but cannot remove, ha!"
                tagsInput.allowDuplicates false
                tagsInput.caseSensitive false
                tagsInput.closeDropdownOnItemSelect false
                tagsInput.tagsRemovable false
                tagsInput.tagProperties [ tag.isRounded; color.isWarning ]
                tagsInput.autoTrim true
                tagsInput.removeSelectedFromAutoComplete true
                tagsInput.allowOnlyAutoCompleteValues false
                tagsInput.maxTags 10
            ]

        ]

        Bulma.content [
            Bulma.title.h5 "Controlled vs Uncontrolled input"
            Html.p [ prop.dangerouslySetInnerHTML "All previous examples are using uncontrolled approach. If you need to have control over input state, use <i>value</i> instead of <i>defaultValue</i>" ]
            code """let myValue,setMyValue = React.useState(["default";"tags"])

Bulma.notification [
    color.isDark
    prop.children [
        Html.p $"My tags are: {myValue}"
        Bulma.button.button [
            color.isLight
            prop.text "Clear tags"
            prop.onClick (fun _ -> [] |> setMyValue)
        ]
    ]

]
TagsInput.input [
    tagsInput.value myValue
    tagsInput.onTagsChanged setMyValue
]
"""
            Bulma.notification [
                color.isDark
                prop.children [
                    Html.p $"My tags are: {myValue}"
                    Bulma.button.button [
                        color.isLight
                        prop.text "Clear tags"
                        prop.onClick (fun _ -> [] |> setMyValue)
                    ]
                ]

            ]
            TagsInput.input [
                tagsInput.value myValue
                tagsInput.onTagsChanged setMyValue
            ]
        ]

    ] |> React.fragment

let view =
    ComponentView
        "TagsInput"
        "Feliz.Bulma.TagsInput"
        "https://bulma-tagsinput.netlify.app/"
        (Description())
        (installationView "Feliz.Bulma.TagsInput" "@creativebulma/bulma-tagsinput" "@creativebulma/bulma-tagsinput")
