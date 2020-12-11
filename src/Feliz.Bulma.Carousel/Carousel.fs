namespace Feliz.Bulma.Carousel

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Feliz.Bulma

module private Props =
    let inline setDefault<'a> (name:string, value:obj) (props:List<'a>) =
        let found =
            props
            |> List.map unbox<string * _>
            |> List.exists (fun (n,_) -> n = name)
        match found with
        | true -> props
        | false -> (unbox (name, value)) :: props

module private ElementLiterals =
    let [<Literal>] slider = "slider"
    let [<Literal>] sliderContainer = "slider-container"
    let [<Literal>] sliderItem = "slider-item"

[<RequireQualifiedAccess; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module Carousel =
    type Props =
        abstract slides: ReactElement list

    [<ReactComponent>]
    let Carousel (p:Props) =
        let slidesToShow = 3
        let slidesPadding = 15

        let translate, setTranslate = React.useState(0.)
        let parentWidth, setParentWidth =
            let getter, setter = React.useState(0.)
            getter, (if getter > 0. then ignore else setter)


        let slideWidth = parentWidth / (float slidesToShow) //- (float slidesPadding)
        let fullWidth = slideWidth * (float p.slides.Length)
        let moveRight _ = (translate + slideWidth) |> setTranslate
        let moveLeft _ = (translate - slideWidth) |> setTranslate

        Html.div [
            prop.style [ style.overflow.hidden ]
            prop.className ElementLiterals.slider
            prop.ref (fun x ->
                if x |> isNull |> not then
                    JS.console.log (x.getBoundingClientRect().width)
                    x.getBoundingClientRect().width |> setParentWidth
            )
            prop.children [
                Html.div [
                    prop.style [
                        style.opacity 1.
                        style.width (int parentWidth)
                        style.transitionProperty "all"
                        style.transitionDurationMilliseconds 300
                        style.transitionTimingFunction.ease
                        style.transitionDelayMilliseconds 0
                        style.transform.translate3D (int translate, 0, 0)
                    ]
                    prop.className ElementLiterals.sliderContainer
                    prop.children [
                        for slide in p.slides do
                            Html.div [
                                prop.style [ style.width (int slideWidth) ]
                                prop.className ElementLiterals.sliderItem
                                prop.children [ slide ]
                            ]
                    ]
                ]
                Html.div [
                    prop.className "slider-navigation-previous"
                    prop.children [
                        Html.i [
                            prop.className "fas fa-chevron-left"
                        ]
                    ]
                    prop.onClick moveRight
                ]
                Html.div [
                    prop.className "slider-navigation-next"
                    prop.children [
                        Html.i [
                            prop.className "fas fa-chevron-right"
                        ]
                    ]
                    prop.onClick moveLeft
                ]
            ]
        ]

type ICarouselProperty = interface end

[<Erase>]
type carousel =
    static member inline slides (slides:ReactElement list) : ICarouselProperty = unbox ("slides", slides)

[<Erase>]
type Carousel =
    static member inline carousel (props: ICarouselProperty list) =
        let safeProps =
            props
            |> Props.setDefault ("slides", [])
        Carousel.Carousel (unbox<Carousel.Props> (createObj !!safeProps))
