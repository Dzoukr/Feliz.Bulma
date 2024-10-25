open Fake
open Fake.Core
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.Core.TargetOperators
open System.IO
open BuildHelpers
open BuildTools

initializeContext()

let docsSrcPath = "src" </> "Docs"
let docsPublishPath = "publish" </> "docs"
let fableBuildPath = ".fable-build" //docsSrcPath </> ".fable-build"

// Targets
let clean proj = [ proj </> "bin"; proj </> "obj" ] |> Shell.cleanDirs

let validateFemto proj = Tools.dotnet $"femto --validate {proj}" "."

let createNuget proj =
    clean proj
    validateFemto proj
    Tools.yarn "install" proj
    Tools.dotnet "restore --no-cache" proj
    Tools.dotnet "pack -c Release" proj

let publishNuget proj =
    createNuget proj
    let nugetKey =
        match Environment.environVarOrNone "NUGET_KEY" with
        | Some nugetKey -> nugetKey
        | None -> failwith "The Nuget API key must be set in a NUGET_KEY environmental variable"
    let nupkg =
        Directory.GetFiles(proj </> "bin" </> "Release")
        |> Seq.head
        |> Path.GetFullPath
    Tools.dotnet (sprintf "nuget push %s -s nuget.org -k %s" nupkg nugetKey) proj

Target.create "PackBulma" (fun _ -> "src" </> "Feliz.Bulma" |> createNuget)
Target.create "PublishBulma" (fun _ -> "src" </> "Feliz.Bulma" |> publishNuget)

Target.create "PackQuickView" (fun _ -> "src" </> "Feliz.Bulma.QuickView" |> createNuget)
Target.create "PublishQuickView" (fun _ -> "src" </> "Feliz.Bulma.QuickView" |> publishNuget)

Target.create "PackTooltip" (fun _ -> "src" </> "Feliz.Bulma.Tooltip" |> createNuget)
Target.create "PublishTooltip" (fun _ -> "src" </> "Feliz.Bulma.Tooltip" |> publishNuget)

Target.create "PackCheckradio" (fun _ -> "src" </> "Feliz.Bulma.Checkradio" |> createNuget)
Target.create "PublishCheckradio" (fun _ -> "src" </> "Feliz.Bulma.Checkradio" |> publishNuget)

Target.create "PackSwitch" (fun _ -> "src" </> "Feliz.Bulma.Switch" |> createNuget)
Target.create "PublishSwitch" (fun _ -> "src" </> "Feliz.Bulma.Switch" |> publishNuget)

Target.create "PackPopover" (fun _ -> "src" </> "Feliz.Bulma.Popover" |> createNuget)
Target.create "PublishPopover" (fun _ -> "src" </> "Feliz.Bulma.Popover" |> publishNuget)

Target.create "PackPageLoader" (fun _ -> "src" </> "Feliz.Bulma.PageLoader" |> createNuget)
Target.create "PublishPageLoader" (fun _ -> "src" </> "Feliz.Bulma.PageLoader" |> publishNuget)

Target.create "PackDateTimePicker" (fun _ -> "src" </> "Feliz.Bulma.DateTimePicker" |> createNuget)
Target.create "PublishDateTimePicker" (fun _ -> "src" </> "Feliz.Bulma.DateTimePicker" |> publishNuget)

Target.create "PackDivider" (fun _ -> "src" </> "Feliz.Bulma.Divider" |> createNuget)
Target.create "PublishDivider" (fun _ -> "src" </> "Feliz.Bulma.Divider" |> publishNuget)

Target.create "PackBadge" (fun _ -> "src" </> "Feliz.Bulma.Badge" |> createNuget)
Target.create "PublishBadge" (fun _ -> "src" </> "Feliz.Bulma.Badge" |> publishNuget)

Target.create "PackSlider" (fun _ -> "src" </> "Feliz.Bulma.Slider" |> createNuget)
Target.create "PublishSlider" (fun _ -> "src" </> "Feliz.Bulma.Slider" |> publishNuget)

Target.create "PackTimeline" (fun _ -> "src" </> "Feliz.Bulma.Timeline" |> createNuget)
Target.create "PublishTimeline" (fun _ -> "src" </> "Feliz.Bulma.Timeline" |> publishNuget)

Target.create "PackTagsInput" (fun _ -> "src" </> "Feliz.Bulma.TagsInput" |> createNuget)
Target.create "PublishTagsInput" (fun _ -> "src" </> "Feliz.Bulma.TagsInput" |> publishNuget)


Target.create "InstallDocs" (fun _ ->
    printfn "Node version:"
    Tools.node "--version" docsSrcPath
    printfn "Yarn version:"
    Tools.yarn "--version" docsSrcPath
    Tools.yarn "install --frozen-lockfile" docsSrcPath
)

Target.create "PublishDocs" (fun _ ->
    [ docsPublishPath] |> Shell.cleanDirs

    Tools.dotnet ($"fable --outDir %s{fableBuildPath}") docsSrcPath
    Tools.dotnet ($"npx vite build") docsSrcPath
)

Target.create "RunDocs" (fun _ ->
    // When running Fable and Vite we need to run them in parallel and Fable in verbose mode
    // otherwise sometimes the processess hangs up because of the console rewriting
    runParallel [
        "fable", createProcess "dotnet" $"fable watch --outDir {fableBuildPath} --verbose" docsSrcPath
        "vite", createProcess "npx" "vite serve" docsSrcPath
    ]
)

Target.create "PublishAll" (fun _ ->
    [
        "PublishBulma"
        "PublishQuickView"
        "PublishTooltip"
        "PublishCheckradio"
        "PublishSwitch"
        "PublishPopover"
        "PublishPageLoader"
        "PublishDateTimePicker"
        "PublishDivider"
        "PublishBadge"
        "PublishSlider"
        "PublishTimeline"
        "PublishTagsInput"
    ]
    |> List.iter (fun x -> Target.run 1 x [])
)

let dependencies = [
    "InstallDocs" ==> "RunDocs"
    "InstallDocs" ==> "PublishDocs"
]

[<EntryPoint>]
let main args = runOrDefault "RunDocs" args
