let doType elm name className =
    """
    static member inline {NAME} props = ElementBuilders.{ELM}.props "{CLASS}" props
    static member inline {NAME} elms = ElementBuilders.{ELM}.children "{CLASS}" elms
    static member inline {NAME} elm = ElementBuilders.{ELM}.valueElm "{CLASS}" elm
    static member inline {NAME} s = ElementBuilders.{ELM}.valueStr "{CLASS}" s
    static member inline {NAME} i = ElementBuilders.{ELM}.valueInt "{CLASS}" i
    """
    |> fun x -> x.Replace("{NAME}", name).Replace("{CLASS}", className).Replace("{ELM}", elm)

let doModule modul elm =
    """
    module {MODULE} =
        let inline props (cn:string) (xs:seq<IReactProperty>) = Html.{ELM} [ yield! xs; yield Helpers.propClasses cn xs ]
        let inline children (cn:string) (children:seq<ReactElement>) = Html.{ELM} [ prop.className cn; prop.children children ]
        let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
        let inline valueStr (cn:string) (value:string) = Html.{ELM} [ prop.className cn; prop.text value ]
        let inline valueInt (cn:string) (value:int) = Html.{ELM} [ prop.className cn; prop.text value ]
    """
    |> fun x -> x.Replace("{MODULE}", modul).Replace("{ELM}", elm)

let doIs max =
    let item v =
        "let is{NUM} = PropertyBuilders.mkClass \"is-{NUM}\""
        |> fun x -> x.Replace("{NUM}", string v)
        |> System.Console.WriteLine
    [1..max] |> List.iter item
    

doModule "Footer" "footer"
doType "Div" "heroFoot" "hero-foot"
doType "Div" "tile" "tile"
doIs 12
