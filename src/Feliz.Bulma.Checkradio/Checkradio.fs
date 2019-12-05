namespace Feliz.Bulma.Checkradio

open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] ``is-checkradio`` = "is-checkradio"
    let [<Literal>] ``checkbox`` = "checkbox"
    let [<Literal>] ``radio`` = "radio"

type Checkradio =
    static member inline checkbox props = 
        ElementBuilders.Input.propsWithType ElementLiterals.``is-checkradio`` ElementLiterals.``checkbox`` props
    static member inline radio props = 
        ElementBuilders.Input.propsWithType ElementLiterals.``is-checkradio`` ElementLiterals.``radio`` props