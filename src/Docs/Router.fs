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
    | TooltipOverview
    | TooltipInstallation
    | CheckradioOverview
    | CheckradioInstallation
    | PopoverOverview
    | PopoverInstallation
    | PageLoaderOverview
    | PageLoaderInstallation

let defaultPage = BulmaOverview
    
let parseUrl = function
    | [ "" ] -> BulmaOverview 
    | [ "installation" ] -> BulmaInstallation 
    | [ "api-description" ] -> BulmaAPIDescription 
    | [ "quickview"; "installation" ] -> QuickViewInstallation 
    | [ "quickview" ] -> QuickViewOverview
    | [ "calendar"; "installation" ] -> CalendarInstallation 
    | [ "calendar" ] -> CalendarOverview 
    | [ "tooltip"; "installation" ] -> TooltipInstallation 
    | [ "tooltip" ] -> TooltipOverview 
    | [ "checkradio"; "installation" ] -> CheckradioInstallation 
    | [ "checkradio" ] -> CheckradioOverview 
    | [ "popover"; "installation" ] -> PopoverInstallation 
    | [ "popover" ] -> PopoverOverview 
    | [ "pageloader"; "installation" ] -> PageLoaderInstallation 
    | [ "pageloader" ] -> PageLoaderOverview 
    | _ -> defaultPage
    
let getHref = function
    | BulmaOverview -> Router.format("")
    | BulmaInstallation -> Router.format("installation")
    | BulmaAPIDescription -> Router.format("api-description")
    | QuickViewOverview -> Router.format("quickview")
    | QuickViewInstallation -> Router.format("quickview","installation")
    | CalendarOverview -> Router.format("calendar")
    | CalendarInstallation -> Router.format("calendar","installation")
    | TooltipOverview -> Router.format("tooltip")
    | TooltipInstallation -> Router.format("tooltip","installation")
    | CheckradioOverview -> Router.format("checkradio")
    | CheckradioInstallation -> Router.format("checkradio","installation")
    | PopoverOverview -> Router.format("popover")
    | PopoverInstallation -> Router.format("popover","installation")
    | PageLoaderOverview -> Router.format("pageloader")
    | PageLoaderInstallation -> Router.format("pageloader","installation")
    