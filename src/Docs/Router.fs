module Docs.Router

open Feliz.Router

type Page =
    | BulmaOverview
    | BulmaInstallation
    | BulmaAPIDescription
    | QuickViewOverview
    | QuickViewInstallation
let defaultPage = BulmaOverview
    
let parseUrl = function
    | [ "" ] -> BulmaOverview 
    | [ "installation" ] -> BulmaInstallation 
    | [ "api-description" ] -> BulmaAPIDescription 
    | [ "quickview"; "installation" ] -> QuickViewInstallation 
    | [ "quickview" ] -> QuickViewOverview 
    | _ -> defaultPage
    
let getHref = function
    | BulmaOverview -> Router.format("")
    | BulmaInstallation -> Router.format("installation")
    | BulmaAPIDescription -> Router.format("api-description")
    | QuickViewOverview -> Router.format("quickview")
    | QuickViewInstallation -> Router.format("quickview","installation")