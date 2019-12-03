module Docs.Views.Calendar

open System
open Feliz
open Feliz.Bulma
open Feliz.Bulma.Extensions.Calendar
open Shared

let overview =
    let calcRanged =
        Calendar.calendar [
            prop.id "RangeCal"
            calendar.options [
                calendar.options.type'.datetime
                calendar.options.isRange true
                calendar.options.weekStart DayOfWeek.Monday
            ]
            calendar.onValueSelected (fun x ->
                Fable.Core.JS.console.log(x)
            )
        ]
        
    let calcDialog =
        Calendar.calendar [
            prop.id "DialogCal"
            calendar.options [
                calendar.options.type'.date
                calendar.options.isRange false
                calendar.options.displayMode.dialog
                calendar.options.weekStart DayOfWeek.Monday
                calendar.options.disabledWeekDays [
                    DayOfWeek.Saturday
                    DayOfWeek.Sunday
                ]
            ]
            calendar.onValueSelected (fun x ->
                Fable.Core.JS.console.log(x)
            )
        ]
       
    Html.div [
        Bulma.title [
            Html.text "Feliz.Bulma.Extensions.Calendar "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.Extensions.Calendar/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Extensions.Calendar.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle [
            Html.a [ prop.href "https://creativebulma.net/product/calendar/demo"; prop.text "Calendar" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Calendar component"
            code """open Feliz.Bulma.Extensions.Calendar
            
Calendar.calendar [
    prop.id "RangeCal"
    calendar.options [
        calendar.options.type'.datetime
        calendar.options.isRange true
        calendar.options.weekStart DayOfWeek.Monday
    ]
    calendar.onValueSelected (fun x ->
        Fable.Core.JS.console.log(x)
    )
]"""
            Html.p "Code above will generate ranged calendar:"
            calcRanged
        ]
        Bulma.content [
            Bulma.title4 "OnValueSelected arguments"
            Html.p [ prop.dangerouslySetInnerHTML "When value selected or calendar closed, strongly typed <code>SelectedValue</code> is passed to callback function <code>onValueSelected</code>" ]
            code """type TimeValue = { Hours : int; Minutes : int }

type SingleValue =
    | Date of DateTime option
    | DateTime of DateTime option
    | Time of TimeValue

type RangeValue =
    | Date of DateTime option * DateTime option
    | DateTime of DateTime option * DateTime option
    | Time of TimeValue * TimeValue

type SelectedValue =
    | SingleValue of SingleValue
    | RangeValue of RangeValue
"""
        ]
        
        Bulma.content [
            Bulma.title4 "Configuration"
            Html.p "Calendar component supports various options for configuration"
            code """Calendar.calendar [
    prop.id "DialogCal"
    calendar.options [
        calendar.options.type'.date
        calendar.options.isRange false
        calendar.options.displayMode.dialog
        calendar.options.weekStart DayOfWeek.Monday
        calendar.options.disabledWeekDays [
            DayOfWeek.Saturday
            DayOfWeek.Sunday
        ]
    ]
    calendar.onValueSelected (fun x ->
        Fable.Core.JS.console.log(x)
    )
]
"""
            Html.p "Code above will generate dialog calendar:"
            calcDialog
        ]
        Bulma.content [
            Html.p [ prop.dangerouslySetInnerHTML "Explore <i>calendar.options.*</i> to find all available configuration options or look at official <a href='https://demo.creativebulma.net/components/calendar/v6//#options'>component documentation.</a>" ]
        ]
    ]

let installation =
    Html.div [
        Bulma.title "Feliz.Bulma.Extensions.Calendar - Installation"
        Html.hr []
        Bulma.content [
            Bulma.title4 "Using Femto (recommended)"
            Html.p [ prop.dangerouslySetInnerHTML "The easiest way is to use <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> which will take care of all dependencies including npm libraries." ]
            code "femto install Feliz.Bulma.Extensions.Calendar"
        ]
        Bulma.content [
            Bulma.title4 "Manual"
            Html.p "If you want to install this package manually, use usual NuGet package command"
            code "Install-Package Feliz.Bulma.Extensions.Calendar"
            Html.p "or using Paket"
            code "paket add Feliz.Feliz.Bulma.Extensions.Calendar"
            Html.p "Please don't forget that this library has also dependencies on frontend (css styles), so you need to add it to package.json file using yarn / npm command"
            code "yarn add bulma-calendar"
        ]
    ]