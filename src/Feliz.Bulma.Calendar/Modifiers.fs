namespace Feliz.Bulma.Calendar

open System
open Feliz

module internal PropertyBuilders = 
    let inline mkOpt (key: string) (value: obj) : ICalendarOption = unbox (key, value)

module calendar =
    module options =
        [<Fable.Core.Erase>]       
        type type' =
            static member inline date = PropertyBuilders.mkOpt "type" "date"
            static member inline datetime = PropertyBuilders.mkOpt "type" "datetime"
            static member inline time = PropertyBuilders.mkOpt "type" "time"
        
        [<Fable.Core.Erase>]       
        type displayMode =
            static member inline default' = PropertyBuilders.mkOpt "displayMode" "default"
            static member inline dialog = PropertyBuilders.mkOpt "displayMode" "dialog"
            static member inline inline' = PropertyBuilders.mkOpt "displayMode" "inline"
        
        [<Fable.Core.Erase>]       
        type headerPosition =
            static member inline top = PropertyBuilders.mkOpt "headerPosition" "top"
            static member inline bottom = PropertyBuilders.mkOpt "headerPosition" "bottom"
        
        [<Fable.Core.Erase>]       
        type icons =
            static member inline previous (c:string) = PropertyBuilders.mkOpt "icons.previous" c
            static member inline next (c:string) = PropertyBuilders.mkOpt "icons.next" c
            static member inline time (c:string) = PropertyBuilders.mkOpt "icons.time" c
            static member inline date (c:string) = PropertyBuilders.mkOpt "icons.date" c
        
    [<Fable.Core.Erase>]       
    type options =
        static member inline color (c:string) = PropertyBuilders.mkOpt "color" c
        static member inline isRange (v:bool) = PropertyBuilders.mkOpt "isRange" v
        static member inline allowSameDayRange (v:bool) = PropertyBuilders.mkOpt "allowSameDayRange" v
        static member inline lang (v:string) = PropertyBuilders.mkOpt "lang" v
        static member inline dateFormat (v:string) = PropertyBuilders.mkOpt "dateFormat" v
        static member inline timeFormat (v:string) = PropertyBuilders.mkOpt "timeFormat" v
        static member inline position (v:string) = PropertyBuilders.mkOpt "position" v
        static member inline showHeader (v:bool) = PropertyBuilders.mkOpt "showHeader" v
        static member inline showFooter (v:bool) = PropertyBuilders.mkOpt "showFooter" v
        static member inline showButtons (v:bool) = PropertyBuilders.mkOpt "showButtons" v
        static member inline showTodayButton (v:bool) = PropertyBuilders.mkOpt "showTodayButton" v
        static member inline showClearButton (v:bool) = PropertyBuilders.mkOpt "showClearButton" v
        static member inline cancelLabel (v:string) = PropertyBuilders.mkOpt "cancelLabel" v
        static member inline clearLabel (v:string) = PropertyBuilders.mkOpt "clearLabel" v
        static member inline todayLabel (v:string) = PropertyBuilders.mkOpt "todayLabel" v
        static member inline nowLabel (v:string) = PropertyBuilders.mkOpt "nowLabel" v
        static member inline validateLabel (v:string) = PropertyBuilders.mkOpt "validateLabel" v
        static member inline enableMonthSwitch (v:bool) = PropertyBuilders.mkOpt "enableMonthSwitch" v
        static member inline enableYearSwitch (v:bool) = PropertyBuilders.mkOpt "enableYearSwitch" v
        static member inline startDate (v:DateTime) = PropertyBuilders.mkOpt "startDate" v
        static member inline endDate (v:DateTime) = PropertyBuilders.mkOpt "endDate" v
        static member inline minDate (v:DateTime) = PropertyBuilders.mkOpt "minDate" v
        static member inline maxDate (v:DateTime) = PropertyBuilders.mkOpt "maxDate" v
        static member inline disabledDates (v:DateTime list) = PropertyBuilders.mkOpt "disabledDates" (v |> Array.ofList)
        static member inline disabledWeekDays (v:DayOfWeek list) = PropertyBuilders.mkOpt "disabledWeekDays" (v |> Array.ofList)
        static member inline weekStart (v:DayOfWeek) = PropertyBuilders.mkOpt "weekStart" v
        static member inline minuteSteps (v:int) = PropertyBuilders.mkOpt "minuteSteps" v
        static member inline labelFrom (v:string) = PropertyBuilders.mkOpt "labelFrom" v
        static member inline labelTo (v:string) = PropertyBuilders.mkOpt "labelTo" v
        static member inline closeOnOverlayClick (v:bool) = PropertyBuilders.mkOpt "closeOnOverlayClick" v
        static member inline closeOnSelect (v:bool) = PropertyBuilders.mkOpt "closeOnSelect" v
            

[<Fable.Core.Erase>]       
type calendar =
    static member inline onValueSelected (handler: SelectedValue -> unit) = Interop.mkAttr "onValueSelected" handler
    static member inline options (opts:ICalendarOption list) = Interop.mkAttr "calendarOptions" opts
