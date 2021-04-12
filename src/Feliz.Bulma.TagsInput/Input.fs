namespace Feliz.Bulma

open System
open Browser.Types
open Browser.Dom
open Fable.Core.JsInterop
open Fable.Core
open Feliz
open Feliz.Bulma

module internal Hook =
    let useOnClickOutside(ref:IRefValue<#HTMLElement option>, handler) =
        React.useEffect(
            (fun _ ->
                let listener = (fun (event:Event) ->
                    if (isNullOrUndefined ref.current || ref.current.Value.contains(event.target :?> _)) then ()
                    else handler(event)
                )
                document.addEventListener("mousedown", listener)
                document.addEventListener("touchstart", listener)
                { new IDisposable with
                    member __.Dispose() =
                        document.removeEventListener("mousedown", listener)
                        document.removeEventListener("touchstart", listener)
                    }
            ) , [| box ref; box handler |])

[<RequireQualifiedAccess; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module TagsInputComponent =
    type Props =
        abstract onTagsChanged : (string list -> unit) option
        abstract autoCompleteSource: (string -> Async<string list>) option
        abstract defaultValue: (string list) option
        abstract value: (string list) option
        abstract noResultsLabel: string
        abstract loadingLabel: string
        abstract delimiter: char
        abstract placeholder: string
        abstract allowDuplicates: bool
        abstract caseSensitive: bool
        abstract closeDropdownOnItemSelect: bool
        abstract tagsRemovable: bool
        abstract tagProperties: IReactProperty list
        abstract autoTrim: bool
        abstract removeSelectedFromAutoComplete: bool
        abstract allowOnlyAutoCompleteValues: bool
        abstract maxTags: int


    [<ReactComponent>]
    let input (p:Props) =
        let wrapperRef = React.useElementRef()

        let tags,setTags =
            if p.value |> Option.isSome then
                p.value.Value, ignore
            else
                let v = p.defaultValue |> Option.defaultValue []
                React.useState(v)

        let isDropdownShown,setDropdownShown = React.useState(false)
        let isActive,setIsActive = React.useState(false)
        let inputValue,setInputValue = React.useState("")
        let autoComplete,setAutoComplete = React.useState([])
        let inputLoading,setInputLoading = React.useState(false)

        let focus () =
            setDropdownShown true
            setIsActive true

        let blur () =
            setDropdownShown false
            setIsActive false

        Hook.useOnClickOutside(wrapperRef, fun _ -> blur())

        let changeTags value =
            setTags value
            if p.onTagsChanged.IsSome then p.onTagsChanged.Value value

        let removeTag (index:int) =
            tags
            |> List.mapi (fun i v -> if i <> index then Some v else None)
            |> List.choose id
            |> changeTags

        let loadAutoComplete () = async {
            let filter vals =
                if p.removeSelectedFromAutoComplete then
                    let isSelected v = tags |> List.exists (fun x -> String.Compare(x, v, not p.caseSensitive) = 0)
                    vals |> List.filter (isSelected >> not)
                else vals
            match isDropdownShown, p.autoCompleteSource with
            | true, Some f ->
                setInputLoading true
                let! res = inputValue |> f
                setInputLoading false
                res |> filter |> setAutoComplete
            | _ -> [] |> setAutoComplete
        }

        let addTag (isFromDropdown:bool) (t:string) =
            let t = if p.autoTrim then t.Trim() else t
            let isDuplicate = tags |> List.exists (fun x -> String.Compare(x, t, not p.caseSensitive) = 0)
            let isInAutoComplete = autoComplete |> List.exists (fun x -> String.Compare(x, t, not p.caseSensitive) = 0)
            let canBeAdded =
                (String.IsNullOrWhiteSpace(t) |> not)
                && (isDuplicate && p.allowDuplicates || not isDuplicate)
                && (isInAutoComplete && p.allowOnlyAutoCompleteValues || not p.allowOnlyAutoCompleteValues)
                && (tags.Length + 1 <= p.maxTags)

            if canBeAdded then tags @ [ t ] |> changeTags
            if p.closeDropdownOnItemSelect && isFromDropdown then setDropdownShown false

        let autoCompleteItems =
            match inputLoading, autoComplete with
            | true, _ -> Bulma.dropdownItem.div [ prop.className "empty-title"; prop.text p.loadingLabel ] |> List.singleton
            | false, [] -> Bulma.dropdownItem.div [ prop.className "empty-title"; prop.text p.noResultsLabel ] |> List.singleton
            | false, l -> l |> List.map (fun x -> Bulma.dropdownItem.a [ prop.text x; prop.onClick (fun _ -> addTag true x) ])

        React.useEffect(loadAutoComplete >> Async.StartImmediate, [| box inputValue; box isDropdownShown; box tags |])

        let onKeyDown (k:KeyboardEvent) =
            if k.key.ToUpperInvariant() = "ENTER" then
                addTag false inputValue
                "" |> setInputValue
            else if k.key.Chars(0) = p.delimiter then
                inputValue.Replace(p.delimiter, Char.MinValue) |> addTag false
                "" |> setInputValue
                k.preventDefault()

        Bulma.control.div [
            if inputLoading then control.isLoading
            prop.children [
                Html.div [
                    prop.classes [ "tags-input"; if isActive then "is-active" ]
                    prop.ref wrapperRef
                    prop.children [
                        yield!
                            tags
                            |> List.mapi (fun i v ->
                                Bulma.tag [
                                    yield! p.tagProperties
                                    prop.children [
                                        Html.text v
                                        if p.tagsRemovable then
                                            Bulma.delete [ prop.onClick (fun _ -> removeTag i) ]
                                    ]
                                ]
                            )

                        Bulma.input.text [
                            prop.autoFocus isDropdownShown
                            prop.onFocus (fun _ -> focus())
                            prop.onKeyDown onKeyDown
                            prop.onTextChange setInputValue
                            prop.placeholder p.placeholder
                        ]

                        if p.autoCompleteSource.IsSome && isDropdownShown then
                            Bulma.dropdownMenu [
                                prop.children [
                                    autoCompleteItems |> Bulma.dropdownContent
                                ]
                            ]
                    ]
                ]
            ]
        ]

type ITagsInputProperty = interface end

[<Erase>]
type tagsInput =
    static member inline onTagsChanged (fn:string list -> unit) : ITagsInputProperty = unbox ("onTagsChanged", fn)
    static member inline autoCompleteSource (src:string -> Async<string list>) : ITagsInputProperty = unbox ("autoCompleteSource", src)
    static member inline value (tags:string list) : ITagsInputProperty = unbox ("value", tags)
    static member inline defaultValue (tags:string list) : ITagsInputProperty = unbox ("defaultValue", tags)
    static member inline noResultsLabel (label:string) : ITagsInputProperty = unbox ("noResultsLabel", label)
    static member inline loadingLabel (label:string) : ITagsInputProperty = unbox ("loadingLabel", label)
    static member inline delimiter (value:char) : ITagsInputProperty = unbox ("delimiter", value)
    static member inline placeholder (value:string) : ITagsInputProperty = unbox ("placeholder", value)
    static member inline allowDuplicates (value:bool) : ITagsInputProperty = unbox ("allowDuplicates", value)
    static member inline caseSensitive (value:bool) : ITagsInputProperty = unbox ("caseSensitive", value)
    static member inline closeDropdownOnItemSelect (value:bool) : ITagsInputProperty = unbox ("closeDropdownOnItemSelect", value)
    static member inline tagsRemovable (value:bool) : ITagsInputProperty = unbox ("tagsRemovable", value)
    static member inline tagProperties (props:IReactProperty list) : ITagsInputProperty = unbox ("tagProperties", props)
    static member inline autoTrim (value:bool) : ITagsInputProperty = unbox ("autoTrim", value)
    static member inline removeSelectedFromAutoComplete (value:bool) : ITagsInputProperty = unbox ("removeSelectedFromAutoComplete", value)
    static member inline allowOnlyAutoCompleteValues (value:bool) : ITagsInputProperty = unbox ("allowOnlyAutoCompleteValues", value)
    static member inline maxTags (value:int) : ITagsInputProperty = unbox ("maxTags", value)


