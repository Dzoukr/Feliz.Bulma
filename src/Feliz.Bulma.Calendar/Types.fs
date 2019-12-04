namespace Feliz.Bulma.Calendar

open System

type TimeValue = { Hours : int; Minutes : int }

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

type ICalendarOption = interface end