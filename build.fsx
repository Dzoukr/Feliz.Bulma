open Fake.IO

#r "paket: groupref Build //"
#load ".fake/build.fsx/intellisense.fsx"

open System.IO
open Fake.Core
open Fake.DotNet
open Fake.IO.FileSystemOperators
open Fake.Core.TargetOperators

module Tools =
    let private findTool tool winTool =
        let tool = if Environment.isUnix then tool else winTool
        match ProcessUtils.tryFindFileOnPath tool with
        | Some t -> t
        | _ ->
            let errorMsg =
                tool + " was not found in path. " +
                "Please install it and make sure it's available from your path. "
            failwith errorMsg
            
    let private runTool (cmd:string) args workingDir =
        let arguments = args |> String.split ' ' |> Arguments.OfArgs
        Command.RawCommand (cmd, arguments)
        |> CreateProcess.fromCommand
        |> CreateProcess.withWorkingDirectory workingDir
        |> CreateProcess.ensureExitCode
        |> Proc.run
        |> ignore
        
    let dotnet cmd workingDir =
        let result =
            DotNet.exec (DotNet.Options.withWorkingDirectory workingDir) cmd ""
        if result.ExitCode <> 0 then failwithf "'dotnet %s' failed in %s" cmd workingDir
    
    let femto args = args |> sprintf "femto %s" |> dotnet        
    let node = runTool (findTool "node" "node.exe")        
    let yarn = runTool (findTool "yarn" "yarn.cmd")             

let docsSrcPath = "src/Docs"
let docsDeployPath = "docs"

// Targets
let clean proj = [ proj </> "bin"; proj </> "obj" ] |> Shell.cleanDirs

let validateFemto proj = Tools.femto "--validate" proj

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
    
Target.create "PackCalendar" (fun _ -> "src" </> "Feliz.Bulma.Calendar" |> createNuget)
Target.create "PublishCalendar" (fun _ -> "src" </> "Feliz.Bulma.Calendar" |> publishNuget)

Target.create "PackTooltip" (fun _ -> "src" </> "Feliz.Bulma.Tooltip" |> createNuget)
Target.create "PublishTooltip" (fun _ -> "src" </> "Feliz.Bulma.Tooltip" |> publishNuget)

Target.create "PackCheckradio" (fun _ -> "src" </> "Feliz.Bulma.Checkradio" |> createNuget)
Target.create "PublishCheckradio" (fun _ -> "src" </> "Feliz.Bulma.Checkradio" |> publishNuget)

Target.create "PackPopover" (fun _ -> "src" </> "Feliz.Bulma.Popover" |> createNuget)
Target.create "PublishPopover" (fun _ -> "src" </> "Feliz.Bulma.Popover" |> publishNuget)

Target.create "PackPageLoader" (fun _ -> "src" </> "Feliz.Bulma.PageLoader" |> createNuget)
Target.create "PublishPageLoader" (fun _ -> "src" </> "Feliz.Bulma.PageLoader" |> publishNuget)

Target.create "InstallDocs" (fun _ ->
    printfn "Node version:"
    Tools.node "--version" docsSrcPath
    printfn "Yarn version:"
    Tools.yarn "--version" docsSrcPath
    Tools.yarn "install --frozen-lockfile" docsSrcPath
)

Target.create "PublishDocs" (fun _ ->
    let docsDeployLocalPath = (docsSrcPath </> "deploy")
    [ docsDeployPath; docsDeployLocalPath] |> Shell.cleanDirs
    Tools.yarn "webpack-cli -p" docsSrcPath
    Shell.copyDir docsDeployPath docsDeployLocalPath FileFilter.allFiles
)

Target.create "RunDocs" (fun _ -> Tools.yarn "webpack-dev-server" docsSrcPath)

"InstallDocs" ==> "RunDocs"
"InstallDocs" ==> "PublishDocs"

Target.runOrDefaultWithArguments "RunDocs"