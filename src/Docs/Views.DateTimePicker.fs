module Docs.Views.DateTimePicker

open System
open Fable.Core
open Feliz
open Feliz.Bulma
open Feliz.Bulma.DateTimePicker
open Fable.DateFunctions

let overview =
    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.Bulma.DateTimePicker "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.DateTimePicker/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.DateTimePicker.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h2 [
            Html.text "DateTimePicker extension for Feliz.Bulma"
        ]
        Html.hr []
        DateTimePicker.timePicker [
            timePicker.onTimeSelected (fun v -> JS.console.log(v))
            timePicker.onTimeRangeSelected (fun v -> JS.console.log(v))
            timePicker.isRange false
            timePicker.displayMode DisplayMode.Default
            timePicker.clearLabel "Smazat"
        ]
        Html.hr []

        DateTimePicker.dateTimePicker [
            dateTimePicker.onDateSelected (fun v -> JS.console.log(v))
            dateTimePicker.onDateRangeSelected (fun v -> JS.console.log(v))
            dateTimePicker.isRange false
            dateTimePicker.displayMode DisplayMode.Default
            dateTimePicker.clearLabel "Smazat"
            dateTimePicker.locale DateTime.Locales.Czech
            dateTimePicker.minDate DateTime.UtcNow
        ]
    ]

let installation = Shared.installationView "Feliz.Bulma.DateTimePicker" "bulma-calendar"
