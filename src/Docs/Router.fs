module Docs.Router

open Feliz.Router

type Page =
    | Overview
    | Installation
    | APIDescription
    | DocumentationOverview
    | DocumentationButton
    | DocumentationCard
    | DocumentationForm
    | DocumentationMediaObject
    | DocumentationModal
    | DocumentationNavbar
    | DocumentationPanel
    | DocumentationProgressbar
    | DocumentationTag
    | DocumentationTabs
    | DocumentationHelpersColor
    | QuickView
    | DateTimePicker
    | Tooltip
    | Checkradio
    | Popover
    | PageLoader
    | Switch
    | Divider
    | Badge
    | Slider
    | Timeline
    | TagsInput

let defaultPage = Overview

let parseUrl = function
    | [ "" ] -> Overview
    | [ "installation" ] -> Installation
    | [ "api-description" ] -> APIDescription
    | [ "documentation"; "overview" ] -> DocumentationOverview
    | [ "documentation"; "button" ] -> DocumentationButton
    | [ "documentation"; "card" ] -> DocumentationCard
    | [ "documentation"; "form" ] -> DocumentationForm
    | [ "documentation"; "media-object" ] -> DocumentationMediaObject
    | [ "documentation"; "modal" ] -> DocumentationModal
    | [ "documentation"; "navbar" ] -> DocumentationNavbar
    | [ "documentation"; "panel" ] -> DocumentationPanel
    | [ "documentation"; "progressbar" ] -> DocumentationProgressbar
    | [ "documentation"; "tag" ] -> DocumentationTag
    | [ "documentation"; "tabs" ] -> DocumentationTabs
    | [ "documentation"; "helpers" ] -> DocumentationHelpersColor
    | [ "quickview" ] -> QuickView
    | [ "datetimepicker" ] -> DateTimePicker
    | [ "tooltip" ] -> Tooltip
    | [ "checkradio" ] -> Checkradio
    | [ "popover" ] -> Popover
    | [ "pageloader" ] -> PageLoader
    | [ "switch" ] -> Switch
    | [ "divider" ] -> Divider
    | [ "badge" ] -> Badge
    | [ "slider" ] -> Slider
    | [ "timeline" ] -> Timeline
    | [ "tagsinput" ] -> TagsInput
    | _ -> defaultPage

let getHref = function
    | Overview -> Router.format ("")
    | Installation -> Router.format ("installation")
    | APIDescription -> Router.format ("api-description")
    | DocumentationOverview -> Router.format ([ "documentation"; "overview" ])
    | DocumentationButton -> Router.format ([ "documentation"; "button" ])
    | DocumentationCard -> Router.format ([ "documentation"; "card" ])
    | DocumentationForm -> Router.format ([ "documentation"; "form" ])
    | DocumentationModal -> Router.format ([ "documentation"; "modal" ])
    | DocumentationMediaObject -> Router.format ([ "documentation"; "media-object" ])
    | DocumentationNavbar -> Router.format ([ "documentation"; "navbar" ])
    | DocumentationPanel -> Router.format ([ "documentation"; "panel" ])
    | DocumentationProgressbar -> Router.format ([ "documentation"; "progressbar" ])
    | DocumentationTag -> Router.format ([ "documentation"; "tag" ])
    | DocumentationTabs -> Router.format ([ "documentation"; "tabs" ])
    | DocumentationHelpersColor -> Router.format ([ "documentation"; "helpers" ])
    | QuickView -> Router.format ("quickview")
    | DateTimePicker -> Router.format ("datetimepicker")
    | Tooltip -> Router.format ("tooltip")
    | Checkradio -> Router.format ("checkradio")
    | Popover -> Router.format ("popover")
    | PageLoader -> Router.format ("pageloader")
    | Switch -> Router.format ("switch")
    | Divider -> Router.format ("divider")
    | Badge -> Router.format ("badge")
    | Slider -> Router.format ("slider")
    | Timeline -> Router.format ("timeline")
    | TagsInput -> Router.format ("tagsinput")
