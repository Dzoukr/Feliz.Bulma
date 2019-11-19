﻿let doType elm name className =
    """
    static member inline {NAME} props = ElementBuilders.{ELM}.props "{CLASS}" props
    static member inline {NAME} (elms:#seq<ReactElement>) = ElementBuilders.{ELM}.children "{CLASS}" elms
    static member inline {NAME} elm = ElementBuilders.{ELM}.valueElm "{CLASS}" elm
    static member inline {NAME} s = ElementBuilders.{ELM}.valueStr "{CLASS}" s
    static member inline {NAME} i = ElementBuilders.{ELM}.valueInt "{CLASS}" i
    """
    |> fun x -> x.Replace("{NAME}", name).Replace("{CLASS}", className).Replace("{ELM}", elm)

let doModule modul elm =
    """
    module {MODULE} =
        let inline props (cn:string) (xs:IReactProperty list) = Html.{ELM} [ yield! xs; yield Helpers.propClasses cn xs ]
        let inline children (cn:string) (children:seq<ReactElement>) = Html.{ELM} [ prop.className cn; prop.children children ]
        let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
        let inline valueStr (cn:string) (value:string) = Html.{ELM} [ prop.className cn; prop.text value ]
        let inline valueInt (cn:string) (value:int) = Html.{ELM} [ prop.className cn; prop.text value ]
    """
    |> fun x -> x.Replace("{MODULE}", modul).Replace("{ELM}", elm)

let hasTextCentered{NAME} = PropertyBuilders.makeClass "has-text-centered-{DEV}"
let hasTextJustified{NAME} = PropertyBuilders.makeClass "has-text-justified-{DEV}"
let hasTextLeft{NAME} = PropertyBuilders.makeClass "has-text-left-{DEV}"
let hasTextRight{NAME} = PropertyBuilders.makeClass "has-text-right-{DEV}"

let doIs list =
    let item (n,d) =
        """
        let hasTextCentered{NAME} = PropertyBuilders.makeClass "has-text-centered-{DEV}"
        let hasTextJustified{NAME} = PropertyBuilders.makeClass "has-text-justified-{DEV}"
        let hasTextLeft{NAME} = PropertyBuilders.makeClass "has-text-left-{DEV}"
        let hasTextRight{NAME} = PropertyBuilders.makeClass "has-text-right-{DEV}"
        """
        
        //"let isSize{NUM}FullHd = PropertyBuilders.mkClass \"is-size-{NUM}-fullhd\""
        |> fun x -> x.Replace("{NAME}", n).Replace("{DEV}",d)
        |> System.Console.WriteLine
    [
        "Mobile", "mobile"
        "Tablet", "tablet"
        "TabletOnly", "tablet-only"
        "Touch", "touch"
        "Desktop", "desktop"
        "DesktopOnly", "desktop-only"
        "Widescreen", "widescreen"
        "WidescreenOnly", "widescreen-only"
        "FullHd", "fullhd"
        
        
    ] |> List.iter item
doIs 7   

let doProps ports v  =
    let vals = [
        for (po,pu) in ports do
            for (p,c) in v do
                yield ("let {PROP}{PO} = PropertyBuilders.mkClass \"{CLASS}-{PU}\"")
                    .Replace("{PROP}", p)
                    .Replace("{CLASS}",c)
                    .Replace("{PO}",po)
                    .Replace("{PU}",pu)
    ]
    
    vals
    |> String.concat "\n"
    |> System.Console.WriteLine

doModule "A" "a"

[1..6]
|> List.map (fun x ->
    doType (sprintf "H%i" x) (sprintf "subtitle%i" x) (sprintf "subtitle is-%i" x)
)
|> List.iter System.Console.WriteLine
doIs 7

doType "Div" "tabs" "tabs"
