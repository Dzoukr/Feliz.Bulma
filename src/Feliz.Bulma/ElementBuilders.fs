module Feliz.Bulma.ElementBuilders

open Feliz

module Helpers =
    let getClasses (xs:IReactProperty list) =
        xs
        |> List.map unbox<string * obj>
        |> List.filter (fun (v,_) -> v = "className")
        |> List.map (snd >> string)
    
    let propClasses cn (xs:IReactProperty list) =
        xs
        |> getClasses
        |> List.append [cn]
        |> fun x -> prop.classes x
        
module Div =
    let inline props (cn:string) (xs:IReactProperty list) = Html.div [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.div [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.div [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.div [ prop.className cn; prop.text value ]
    
module Nav =
    let inline props (cn:string) (xs:IReactProperty list) = Html.nav [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.nav [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Article =
    let inline props (cn:string) (xs:IReactProperty list) = Html.article [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.article [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    
module Section =
    let inline props (cn:string) (xs:IReactProperty list) = Html.section [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.section [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    
module Footer =
    let inline props (cn:string) (xs:IReactProperty list) = Html.footer [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.footer [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Label =
    let inline props (cn:string) (xs:IReactProperty list) = Html.label [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.label [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    
module Input =
    let inline props (cn:string) (xs:IReactProperty list) = Html.input [ yield! xs; yield Helpers.propClasses cn xs ]
    
module Textarea =
    let inline props (cn:string) (xs:IReactProperty list) = Html.textarea [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.textarea [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    
module Button =
    let inline props (cn:string) (xs:IReactProperty list) = Html.button [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.button [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.button [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.button [ prop.className cn; prop.text value ]

module Span =
    let inline props (cn:string) (xs:IReactProperty list) = Html.span [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.span [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.span [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.span [ prop.className cn; prop.text value ]
    
module Figure =
    let inline props (cn:string) (xs:IReactProperty list) = Html.figure [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.figure [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    
module Progress =
    let inline props (cn:string) (xs:IReactProperty list) = Html.progress [ yield! xs; yield Helpers.propClasses cn xs ]
    let inline children (cn:string) (children:seq<ReactElement>) = Html.progress [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.progress [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.progress [ prop.className cn; prop.text value ]    