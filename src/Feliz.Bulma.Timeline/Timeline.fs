namespace Feliz.Bulma

open Feliz
open Fable.Core
open Feliz.Bulma

module private ElementLiterals =
    let [<Literal>] timeline = "timeline"
    let [<Literal>] timelineHeader = "timeline-header"
    let [<Literal>] timelineItem = "timeline-item"
    let [<Literal>] timelineMarker = "timeline-marker"
    let [<Literal>] timelineContent = "timeline-content"
    let [<Literal>] heading = "heading"

[<Erase>]
type Timeline =
    static member inline timeline xs = xs |> ElementBuilders.Header.props ElementLiterals.timeline
    static member inline timeline (elms:#seq<ReactElement>) = elms |> ElementBuilders.Div.children ElementLiterals.timeline
    static member inline header xs = xs |> ElementBuilders.Header.props ElementLiterals.timelineHeader
    static member inline header (elms:#seq<ReactElement>) = elms |> ElementBuilders.Header.children ElementLiterals.timelineHeader
    static member inline item xs = xs |> ElementBuilders.Div.props ElementLiterals.timelineItem
    static member inline item (elms:#seq<ReactElement>) = elms |> ElementBuilders.Div.children ElementLiterals.timelineItem
    static member inline marker xs = xs |> ElementBuilders.Div.props ElementLiterals.timelineMarker
    static member inline content xs = xs |> ElementBuilders.Div.props ElementLiterals.timelineContent
    static member inline content (elms:#seq<ReactElement>) = elms |> ElementBuilders.Div.children ElementLiterals.timelineContent

module Timeline =
    [<Erase>]
    type content =
        static member inline header v = v |> ElementBuilders.P.valueStr ElementLiterals.heading
        static member inline content (v:string) = Html.p v
        static member inline content (v:int) = Html.p v
        static member inline content (xs:IReactProperty list) = Html.p xs
        static member inline content (children:seq<ReactElement>) = Html.p children
