module Feliz.Bulma.ElementBuilders

open Feliz

module Helpers =
    let getClasses (xs:seq<IReactProperty>) =
        xs
        |> Seq.map unbox<string * obj>
        |> Seq.filter (fun (v,_) -> v = "className")
        |> Seq.map (snd >> string)
    
    let propClasses cn (xs:seq<IReactProperty>) =
        xs
        |> getClasses
        |> Seq.append [cn]
        |> fun x -> prop.classes x
        
module Div =
    let inline props (cn:string) (xs:seq<IReactProperty>) = Html.div [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.div [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.div [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.div [ prop.className cn; prop.text value ]
    
module Nav =
    let inline props (cn:string) (xs:seq<IReactProperty>) = Html.nav [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.nav [ prop.className cn; prop.children children ]

module Article =
    let inline props (cn:string) (xs:seq<IReactProperty>) = Html.article [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.article [ prop.className cn; prop.children children ]

module Figure =
    let inline props (cn:string) (xs:seq<IReactProperty>) = Html.figure [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.figure [ prop.className cn; prop.children children ]
    
module Section =
    let inline props (cn:string) (xs:seq<IReactProperty>) = Html.section [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.section [ prop.className cn; prop.children children ]
    
module Footer =
    let inline props (cn:string) (xs:seq<IReactProperty>) = Html.footer [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.footer [ prop.className cn; prop.children children ]
