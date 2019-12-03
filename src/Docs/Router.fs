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