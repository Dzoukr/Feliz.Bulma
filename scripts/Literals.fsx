﻿open System
open System.IO
open System.Text.RegularExpressions

let file = __SOURCE_DIRECTORY__ + "/src/Feliz.Bulma/Bulma.fs"
let fileUpdated = __SOURCE_DIRECTORY__ + "/src/Feliz.Bulma/BulmaUpdated.fs"
let rows = File.ReadAllLines file

let getToReplace row =
    let m = Regex.Match(row, "\"(.+)\"")
    if m.Success then
        Some m.Groups.[1].Value
    else None

let literal value =
    sprintf "let [<Literal>] ``%s`` = \"%s\"" value value
    
let foundValues =
    rows
    |> Array.choose getToReplace
    |> Array.distinct
    |> Array.map (fun x -> x, literal x)
    |> Array.toList

let header = [ "module private ElementLiterals ="]

let literals =
    foundValues
    |> List.map snd
    |> List.map (fun x -> "    " + x)

let body =
    let foldFn (acc:string) item =
        acc.Replace(sprintf "\"%s\"" item, sprintf "ElementLiterals.``%s``" item)
    
    foundValues
    |> List.map fst
    |> List.fold foldFn (rows |> String.concat Environment.NewLine)

File.WriteAllLines(fileUpdated, header @ literals @ [body])         