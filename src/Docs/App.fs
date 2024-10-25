module Docs.App

open Elmish
open Elmish.React
open Fable.Core.JsInterop

importSideEffects "./styles/styles.scss"

#if DEBUG
open Elmish.HMR
#endif

Program.mkProgram State.init State.update View.view
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.withReactBatched "elmish-app"
|> Program.run
