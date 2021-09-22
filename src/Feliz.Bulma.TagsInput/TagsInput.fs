namespace Feliz.Bulma

open Fable.Core
open Fable.Core.JsInterop

module private Props =
    let inline setDefault<'a> (name:string, value:obj) (props:List<'a>) =
        let found =
            props
            |> List.map unbox<string * _>
            |> List.exists (fun (n,_) -> n = name)
        match found with
        | true -> props
        | false -> (unbox (name, value)) :: props

[<Erase>]
type TagsInput =
    static member inline input (props: ITagsInputProperty list) =
        let safeProps =
            props
            |> Props.setDefault ("noResultsLabel", "No results found")
            |> Props.setDefault ("loadingLabel", "Loading...")
            |> Props.setDefault ("delimiter", ',')
            |> Props.setDefault ("placeholder", "Choose tags")
            |> Props.setDefault ("caseSensitive", true)
            |> Props.setDefault ("allowDuplicates", true)
            |> Props.setDefault ("closeDropdownOnItemSelect", true)
            |> Props.setDefault ("tagsRemovable", true)
            |> Props.setDefault ("tagProperties", [tag.isRounded])
            |> Props.setDefault ("autoTrim", true)
            |> Props.setDefault ("maxTags", System.Int32.MaxValue)
        TagsInputComponent.input (unbox<TagsInputComponent.Props> (createObj !!safeProps))

