namespace Feliz.Bulma

open System
open Feliz
open Browser.Types
open Browser.Dom
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
type DisplayMode =
    | Default
    | Inline

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

module internal Html =
    let divClassed (cn:string) (cont:ReactElement list) =
        Html.div [
            prop.className cn
            prop.children cont
        ]

module internal Layout =
    let wrapper isDisplayed (mode:DisplayMode) (ref:IRefValue<_>) (cont:ReactElement list) =
        Html.div [
            prop.className "datetimepicker-wrapper"
            prop.children [
                Html.div [
                    prop.classes [
                        "datetimepicker"
                        match mode with
                        | DisplayMode.Default -> "is-datetimepicker-default"
                        | DisplayMode.Inline -> ""
                        "is-primary"
                        if isDisplayed then "is-active"
                    ]
                    match mode with
                    | DisplayMode.Default -> prop.style [ style.position.absolute ]
                    | _ -> ()
                    prop.children cont
                ]
            ]
            prop.ref ref
        ]
