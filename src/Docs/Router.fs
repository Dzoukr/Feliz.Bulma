module Docs.Router

open Feliz.Router

type Page =
    | BulmaOverview
    | BulmaInstallation
    | BulmaAPIDescription
let defaultPage = BulmaOverview
    
let parseUrl = function
    | [ "" ] -> BulmaOverview 
    | [ "installation" ] -> BulmaInstallation 
    | [ "api-description" ] -> BulmaAPIDescription 
    | _ -> defaultPage
    
let getHref = function
    | BulmaOverview -> Router.format("")
    | BulmaInstallation -> Router.format("installation")
    | BulmaAPIDescription -> Router.format("api-description")