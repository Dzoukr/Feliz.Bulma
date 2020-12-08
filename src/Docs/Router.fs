module Docs.Router

open Feliz.Router

type Page =
    | BulmaOverview
    | BulmaInstallation
    | BulmaAPIDescription
    | QuickViewOverview
    | QuickViewInstallation
    | CalendarOverview
    | CalendarInstallation
    | DateTimePickerOverview
    | DateTimePickerInstallation
    | TooltipOverview
    | TooltipInstallation
    | CheckradioOverview
    | CheckradioInstallation
    | SwitchOverview
    | SwitchInstallation
    | PopoverOverview
    | PopoverInstallation
    | PageLoaderOverview
    | PageLoaderInstallation
    | DividerOverview
    | DividerInstallation
    | BadgeOverview
    | BadgeInstallation

let defaultPage = BulmaOverview

let parseUrl = function
    | [ "" ] -> BulmaOverview
    | [ "installation" ] -> BulmaInstallation
    | [ "api-description" ] -> BulmaAPIDescription
    | [ "quickview"; "installation" ] -> QuickViewInstallation
    | [ "quickview" ] -> QuickViewOverview
    | [ "calendar"; "installation" ] -> CalendarInstallation
    | [ "calendar" ] -> CalendarOverview
    | [ "datetimepicker"; "installation" ] -> DateTimePickerInstallation
    | [ "datetimepicker" ] -> DateTimePickerOverview
    | [ "tooltip"; "installation" ] -> TooltipInstallation
    | [ "tooltip" ] -> TooltipOverview
    | [ "checkradio"; "installation" ] -> CheckradioInstallation
    | [ "checkradio" ] -> CheckradioOverview
    | [ "switch"; "installation" ] -> SwitchInstallation
    | [ "switch" ] -> SwitchOverview
    | [ "popover"; "installation" ] -> PopoverInstallation
    | [ "popover" ] -> PopoverOverview
    | [ "pageloader"; "installation" ] -> PageLoaderInstallation
    | [ "pageloader" ] -> PageLoaderOverview
    | [ "divider"; "installation" ] -> DividerInstallation
    | [ "divider" ] -> DividerOverview
    | [ "badge"; "installation" ] -> BadgeInstallation
    | [ "badge" ] -> BadgeOverview
    | _ -> defaultPage

let getHref = function
    | BulmaOverview -> Router.format("")
    | BulmaInstallation -> Router.format("installation")
    | BulmaAPIDescription -> Router.format("api-description")
    | QuickViewOverview -> Router.format("quickview")
    | QuickViewInstallation -> Router.format("quickview","installation")
    | CalendarOverview -> Router.format("calendar")
    | CalendarInstallation -> Router.format("calendar","installation")
    | DateTimePickerOverview -> Router.format("datetimepicker")
    | DateTimePickerInstallation -> Router.format("datetimepicker","installation")
    | TooltipOverview -> Router.format("tooltip")
    | TooltipInstallation -> Router.format("tooltip","installation")
    | CheckradioOverview -> Router.format("checkradio")
    | CheckradioInstallation -> Router.format("checkradio","installation")
    | SwitchOverview -> Router.format("switch")
    | SwitchInstallation -> Router.format("switch","installation")
    | PopoverOverview -> Router.format("popover")
    | PopoverInstallation -> Router.format("popover","installation")
    | PageLoaderOverview -> Router.format("pageloader")
    | PageLoaderInstallation -> Router.format("pageloader","installation")
    | DividerOverview -> Router.format("divider")
    | DividerInstallation -> Router.format("divider","installation")
    | BadgeOverview -> Router.format("badge")
    | BadgeInstallation -> Router.format("badge","installation")
