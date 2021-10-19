module Docs.Views.DateTimePicker

open System
open Fable.Core
open Feliz
open Feliz.Bulma
open Fable.DateFunctions

open Shared

let customFormatNote =
        Html.p [
            Html.text "Follow the formatting conventions of "
            Html.a [ prop.href "https://date-fns.org/"; prop.text "date-fns" ]
            Html.text " library."
        ]

let description =
    Html.div [
        Bulma.content [
            Html.p """This library extends Feliz.Bulma by adding DateTimePicker component based on Bulma calendar."""

            Bulma.subtitle.h5 "Time picker (single value)"
            DateTimePicker.timePicker [
                timePicker.onTimeSelected (fun (v:TimeSpan option) -> () (* handle here *))
                timePicker.onShow (fun _ -> JS.console.log("onShow"))
                timePicker.onHide (fun _ -> JS.console.log("onHide"))
            ]
            Html.p ""
            code """open Feliz.Bulma

DateTimePicker.timePicker [
    timePicker.onTimeSelected (fun (v:TimeSpan option) -> () (* handle here *))
]
"""
            Bulma.subtitle.h5 "Time picker (range value)"
            DateTimePicker.timePicker [
                timePicker.clearLabel "Delete everything"
                timePicker.defaultRangeValue (TimeSpan(07,30,0), TimeSpan(12,34,0))
                timePicker.isRange true
                timePicker.onTimeRangeSelected (fun (v:(TimeSpan * TimeSpan) option) -> () (* handle here *))
            ]
            Html.p ""
            code """DateTimePicker.timePicker [
    timePicker.clearLabel "Delete everything"
    timePicker.defaultRangeValue (TimeSpan(07,30,0), TimeSpan(12,34,0))
    timePicker.isRange true
    timePicker.onTimeRangeSelected (fun (v:(TimeSpan * TimeSpan) option) -> () (* handle here *))
]
"""
            Bulma.subtitle.h5 "Time picker (inline range value)"
            DateTimePicker.timePicker [
                timePicker.displayMode DisplayMode.Inline
                timePicker.defaultRangeValue (TimeSpan(07,30,0), TimeSpan(12,34,0))
                timePicker.isRange true
                timePicker.onTimeRangeSelected (fun (v:(TimeSpan * TimeSpan) option) -> () (* handle here *))
            ]
            Html.p ""
            code """DateTimePicker.timePicker [
    timePicker.displayMode DisplayMode.Inline
    timePicker.defaultRangeValue (TimeSpan(07,30,0), TimeSpan(12,34,0))
    timePicker.isRange true
    timePicker.onTimeRangeSelected (fun (v:(TimeSpan * TimeSpan) option) -> () (* handle here *))
]
"""

            Bulma.subtitle.h5 "Time picker events "
            DateTimePicker.timePicker [
                timePicker.onTimeSelected (fun (v:TimeSpan option) -> JS.console.log(sprintf "onTimeSelected %A" v))
                timePicker.onShow (fun _ -> JS.console.log("onShow"))
                timePicker.onHide (fun _ -> JS.console.log("onHide"))
            ]
            Html.p ""
            code """DateTimePicker.timePicker [
    timePicker.onTimeSelected (fun (v:TimeSpan option) -> JS.console.log(sprintf "onTimeSelected %A" v))
    timePicker.onShow (fun _ -> JS.console.log("onShow"))
    timePicker.onHide (fun _ -> JS.console.log("onHide"))
]"""

            Html.hr []
            Bulma.subtitle.h5 "Date picker (single value with CZ locale and minimum date)"
            DateTimePicker.dateTimePicker [
                dateTimePicker.dateOnly true
                dateTimePicker.onDateSelected (fun (d:DateTime option) -> () (* handle here *))
                dateTimePicker.onShow (fun _ -> JS.console.log("onShow"))
                dateTimePicker.onHide (fun _ -> JS.console.log("onHide"))
                dateTimePicker.isRange false
                dateTimePicker.clearLabel "Smazat"
                dateTimePicker.locale DateTime.Locales.Czech
                dateTimePicker.minDate DateTime.UtcNow
                dateTimePicker.closeOnSelect true
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.dateOnly true
    dateTimePicker.onDateSelected (fun (d:DateTime option) -> () (* handle here *))
    dateTimePicker.isRange false
    dateTimePicker.clearLabel "Smazat"
    dateTimePicker.locale DateTime.Locales.Czech
    dateTimePicker.minDate DateTime.UtcNow
    dateTimePicker.closeOnSelect true
]
"""
            Bulma.subtitle.h5 "Date picker (range value)"
            DateTimePicker.dateTimePicker [
                dateTimePicker.dateOnly true
                dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
                dateTimePicker.isRange true
                dateTimePicker.closeOnSelect true
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.dateOnly true
    dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
    dateTimePicker.isRange true
]
"""
            Bulma.subtitle.h5 "Date picker (range inline value)"
            DateTimePicker.dateTimePicker [
                dateTimePicker.dateOnly true
                dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
                dateTimePicker.isRange true
                dateTimePicker.displayMode DisplayMode.Inline
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.dateOnly true
    dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
    dateTimePicker.isRange true
    dateTimePicker.displayMode DisplayMode.Inline
]
"""

            Bulma.subtitle.h5 "Date picker (custom date format)"
            customFormatNote
            DateTimePicker.dateTimePicker [
                dateTimePicker.dateOnly true
                dateTimePicker.dateFormat "dd/MM/yyyy"
                dateTimePicker.defaultValue DateTime.Today
                dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
                dateTimePicker.isRange false
                dateTimePicker.closeOnSelect true
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.dateOnly true
    dateTimePicker.dateFormat "dd/MM/yyyy"
    dateTimePicker.defaultValue DateTime.Today
    dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
    dateTimePicker.isRange false
    dateTimePicker.closeOnSelect true
]
"""

            Bulma.subtitle.h5 "Date picker (editable)"
            Html.p [ Html.text "When editing the date that is no range, user can be allowed to input the date manually."  ]
            DateTimePicker.dateTimePicker [
                dateTimePicker.dateOnly true
                dateTimePicker.dateFormat "dd/MM/yyyy"
                dateTimePicker.defaultValue DateTime.Today
                dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
                dateTimePicker.isRange false
                dateTimePicker.closeOnSelect true
                dateTimePicker.allowTextInput true
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.dateOnly true
    dateTimePicker.dateFormat "dd/MM/yyyy"
    dateTimePicker.defaultValue DateTime.Today
    dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
    dateTimePicker.isRange false
    dateTimePicker.closeOnSelect true
]
"""

            Bulma.subtitle.h5 "Date picker events"
            DateTimePicker.dateTimePicker [
                dateTimePicker.dateOnly true
                dateTimePicker.onDateSelected (fun (d:DateTime option) -> JS.console.log(sprintf "onDateSelected %A" d))
                dateTimePicker.onShow (fun _ -> JS.console.log("onShow"))
                dateTimePicker.onHide (fun _ -> JS.console.log("onHide"))
                dateTimePicker.isRange false
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.dateOnly true
    dateTimePicker.onDateSelected (fun (d:DateTime option) -> JS.console.log(sprintf "onDateSelected %A" d))
    dateTimePicker.onShow (fun _ -> JS.console.log("onShow"))
    dateTimePicker.onHide (fun _ -> JS.console.log("onHide"))
    dateTimePicker.isRange false
]
    """

            Html.hr []
            Bulma.subtitle.h5 "DateTime picker (single value)"
            DateTimePicker.dateTimePicker [
                dateTimePicker.onDateSelected (fun (d:DateTime option) -> () (* handle here *))
                dateTimePicker.defaultValue DateTime.Now
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.onDateSelected (fun (d:DateTime option) -> () (* handle here *))
    dateTimePicker.defaultValue DateTime.Now
]
"""

            Bulma.subtitle.h5 "DateTime picker (ranged value with labels)"
            DateTimePicker.dateTimePicker [
                dateTimePicker.isRange true
                dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
                dateTimePicker.dateFromLabel "Check-in"
                dateTimePicker.dateToLabel "Check-out"
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.isRange true
    dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
    dateTimePicker.dateFromLabel "Check-in"
    dateTimePicker.dateToLabel "Check-out"
]
"""
            Bulma.subtitle.h5 "DateTime picker (ranged value inlined)"
            DateTimePicker.dateTimePicker [
                dateTimePicker.displayMode DisplayMode.Inline
                dateTimePicker.isRange true
                dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
                dateTimePicker.dateFromLabel "Check-in"
                dateTimePicker.dateToLabel "Check-out"
                dateTimePicker.defaultRangeValue (DateTime.Now.AddDays(-1.),DateTime.Now.AddDays(1.))
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.displayMode DisplayMode.Inline
    dateTimePicker.isRange true
    dateTimePicker.onDateRangeSelected (fun (d:(DateTime * DateTime) option) -> () (* handle here *))
    dateTimePicker.dateFromLabel "Check-in"
    dateTimePicker.dateToLabel "Check-out"
    dateTimePicker.defaultRangeValue (DateTime.Now.AddDays(-1.),DateTime.Now.AddDays(1.))
]
"""

            Bulma.subtitle.h5 "DateTime picker (custom date format)"
            customFormatNote
            DateTimePicker.dateTimePicker [
                dateTimePicker.dateFormat "yyyy-MM-dd'T'hh:mm:ss.SSS'Z'"
                dateTimePicker.onDateSelected (fun (d:DateTime option) -> () (* handle here *))
                dateTimePicker.defaultValue DateTime.UtcNow
            ]
            Html.p ""
            code """DateTimePicker.dateTimePicker [
    dateTimePicker.dateFormat "yyyy-MM-dd'T'hh:mm:ss.SSS'Z'"
    dateTimePicker.onDateSelected (fun (d:DateTime option) -> () (* handle here *))
    dateTimePicker.defaultValue DateTime.UtcNow
]
"""
        ]
    ]

let view =
    ComponentView
        "DateTimePicker"
        "Feliz.Bulma.DateTimePicker"
        "https://creativebulma.net/product/calendar/demo"
        description
        (installationViewMultiple "Feliz.Bulma.DateTimePicker" [ "bulma-calendar"; "date-fns" ] "bulma-calendar")
