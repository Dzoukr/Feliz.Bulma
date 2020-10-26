module Feliz.Bulma.ElementBuilders

open Feliz
open Feliz.Bulma

module Helpers =
    let [<Literal>] private ClassName = "className"

    let inline internal getClasses (xs:IReactProperty list) =
        xs
        |> List.choose (unbox<string * obj> >> function
            | (k, v) when k = ClassName -> Some (string v)
            | _ -> None)

    let extractClasses (xs:IReactProperty list) =
        xs
        |> List.rev
        |> List.fold (fun (classes, props) x ->
            match unbox<string * obj> x with
            | (k, v) when k = ClassName -> string v :: classes, props
            | _ -> classes, x :: props) ([], [])

    let combineClasses cn (xs:IReactProperty list) =
        xs
        |> extractClasses
        |> fun (classes, props) -> (cn :: classes |> prop.classes) :: props

module Div =
    let inline props (cn:string) (xs:IReactProperty list) = Html.div (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.div [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.div [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.div [ prop.className cn; prop.text value ]

module Nav =
    let inline props (cn:string) (xs:IReactProperty list) = Html.nav (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.nav [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Article =
    let inline props (cn:string) (xs:IReactProperty list) = Html.article (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.article [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Section =
    let inline props (cn:string) (xs:IReactProperty list) = Html.section (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.section [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Footer =
    let inline props (cn:string) (xs:IReactProperty list) = Html.footer (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.footer [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Label =
    let inline props (cn:string) (xs:IReactProperty list) = Html.label (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.label [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.label [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.label [ prop.className cn; prop.text value ]

module Input =
    let inline propsWithType (cn:string) (typ: IReactProperty) (xs:IReactProperty list) =
        Html.input (typ :: Helpers.combineClasses cn xs)

module Textarea =
    let inline props (cn:string) (xs:IReactProperty list) = Html.textarea (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.textarea [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Button =
    let inline props (cn:string) (xs:IReactProperty list) = Html.button (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.button [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.button [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.button [ prop.className cn; prop.text value ]

module Span =
    let inline props (cn:string) (xs:IReactProperty list) = Html.span (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.span [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.span [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.span [ prop.className cn; prop.text value ]

module Figure =
    let inline props (cn:string) (xs:IReactProperty list) = Html.figure (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.figure [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Progress =
    let inline props (cn:string) (xs:IReactProperty list) = Html.progress (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.progress [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.progress [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.progress [ prop.className cn; prop.text value ]

module Table =
    let inline props (cn:string) (xs:IReactProperty list) = Html.table (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.table [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module H1 =
    let inline props (cn:string) (xs:IReactProperty list) = Html.h1 (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.h1 [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.h1 [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.h1 [ prop.className cn; prop.text value ]

module H2 =
    let inline props (cn:string) (xs:IReactProperty list) = Html.h2 (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.h2 [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.h2 [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.h2 [ prop.className cn; prop.text value ]

module H3 =
    let inline props (cn:string) (xs:IReactProperty list) = Html.h3 (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.h3 [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.h3 [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.h3 [ prop.className cn; prop.text value ]

module H4 =
    let inline props (cn:string) (xs:IReactProperty list) = Html.h4 (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.h4 [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.h4 [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.h4 [ prop.className cn; prop.text value ]

module H5 =
    let inline props (cn:string) (xs:IReactProperty list) = Html.h5 (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.h5 [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.h5 [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.h5 [ prop.className cn; prop.text value ]

module H6 =
    let inline props (cn:string) (xs:IReactProperty list) = Html.h6 (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.h6 [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.h6 [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.h6 [ prop.className cn; prop.text value ]

module Hr =
    let inline props (cn:string) (xs:IReactProperty list) = Html.hr (Helpers.combineClasses cn xs)

module Aside =
    let inline props (cn:string) (xs:IReactProperty list) = Html.aside (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.aside [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module P =
    let inline props (cn:string) (xs:IReactProperty list) = Html.p (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.p [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.p [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.p [ prop.className cn; prop.text value ]

module Ul =
    let inline props (cn:string) (xs:IReactProperty list) = Html.ul (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.ul [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Li =
    let inline props (cn:string) (xs:IReactProperty list) = Html.li (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.li [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module Header =
    let inline props (cn:string) (xs:IReactProperty list) = Html.header (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.header [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn

module A =
    let inline props (cn:string) (xs:IReactProperty list) = Html.a (Helpers.combineClasses cn xs)
    let inline children (cn:string) (children:seq<ReactElement>) = Html.a [ prop.className cn; prop.children children ]
    let inline valueElm (cn:string) (value:ReactElement) = value |> List.singleton |> children cn
    let inline valueStr (cn:string) (value:string) = Html.a [ prop.className cn; prop.text value ]
    let inline valueInt (cn:string) (value:int) = Html.a [ prop.className cn; prop.text value ]
