let doType elm name className =
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



let ports = [
    "",""
    "Mobile", "mobile"
    "Tablet", "tablet"
    "TabletOnly", "tablet-only"
    "Touch", "touch"
    "Desktop", "desktop"
    "DesktopOnly", "desktop-only"
    "Widescreen", "widescreen"
    "WidescreenOnly", "widescreen-only"
    "FullHd", "fullhd"
]

let extendedValues = [
    "is1", "is-1"
    "is2", "is-2"
    "is3", "is-3"
    "is4", "is-4"
    "is5", "is-5"
    "is6", "is-6"
    "is7", "is-7"
    "is8", "is-8"
    "is9", "is-9"
    "is10", "is-10"
    "is11", "is-11"
    "is12", "is-12"
]

let values = [

    "isThreeQuarters", "is-three-quarters"
    "isTwoThirds", "is-two-thirds"
    "isHalf", "is-half"
    "isOneThird", "is-one-third"
    "isOneQuarter", "is-one-quarter"
    "isFull", "is-full"
    "isFourFifths", "is-four-fifths"
    "isThreeFifths", "is-three-fifths"
    "isTwoFifths", "is-two-fifths"
    "isOneFifth", "is-one-fifth"
    "isNarrow", "is-narrow"

    "isOffset1", "is-offset-1"
    "isOffset2", "is-offset-2"
    "isOffset3", "is-offset-3"
    "isOffset4", "is-offset-4"
    "isOffset5", "is-offset-5"
    "isOffset6", "is-offset-6"
    "isOffset7", "is-offset-7"
    "isOffset8", "is-offset-8"
    "isOffset9", "is-offset-9"
    "isOffset10", "is-offset-10"
    "isOffset11", "is-offset-11"
    "isOffset12", "is-offset-12"

    "isOffsetThreeQuarters", "is-offset-three-quarters"
    "isOffsetTwoThirds", "is-offset-two-thirds"
    "isOffsetHalf", "is-offset-half"
    "isOffsetOneThird", "is-offset-one-third"
    "isOffsetOneQuarter", "is-offset-one-quarter"
    "isOffsetFull", "is-offset-full"
    "isOffsetFourFifths", "is-offset-four-fifths"
    "isOffsetThreeFifths", "is-offset-three-fifths"
    "isOffsetTwoFifths", "is-offset-two-fifths"
    "isOffsetOneFifth", "is-offset-one-fifth"

]

[
    for vn,vc in extendedValues do
        for pn,pc in ports do
            let nc = if pc.Length > 0 then $"{vc}-{pc}" else vc
            //$"static member inline {vn+pn} = PropertyBuilders.mkClass ClassLiterals.``{nc}``"
            $"let [<Literal>] ``{nc}`` = \"{nc}\""
]
|> (fun lines -> System.IO.File.WriteAllLines("c:\\temp\\newbulma.txt", lines))






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
