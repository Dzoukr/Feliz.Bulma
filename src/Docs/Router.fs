﻿module Docs.Router

open Feliz.Router

type Page =
    | Overview
    | Installation
    | APIDescription
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
    | Overview -> Router.format("")
    | Installation -> Router.format("installation")
    | APIDescription -> Router.format("api-description")
    | QuickView -> Router.format("quickview")
    | DateTimePicker -> Router.format("datetimepicker")
    | Tooltip -> Router.format("tooltip")
    | Checkradio -> Router.format("checkradio")
    | Popover -> Router.format("popover")
    | PageLoader -> Router.format("pageloader")
    | Switch -> Router.format("switch")
    | Divider -> Router.format("divider")
    | Badge -> Router.format("badge")
    | Slider -> Router.format("slider")
    | Timeline -> Router.format("timeline")
    | TagsInput -> Router.format("tagsinput")
