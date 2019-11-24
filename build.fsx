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
    
    let femto = runTool "femto"        
    let node = runTool (findTool "node" "node.exe")        
    let yarn = runTool (findTool "yarn" "yarn.cmd")             

let sandboxPath = "sandbox"

// Targets
let clean proj = [ proj </> "bin"; proj </> "obj" ] |> Shell.cleanDirs

let validateFemto proj = Tools.femto "--validate" proj

let createNuget proj =
    clean proj
    validateFemto proj
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
Target.create "PublishBulma" (fun _ -> "src" </> "Feliz.Bulma" |> createNuget)
Target.create "PackQuickView" (fun _ -> "src" </> "Feliz.Bulma.Extensions.QuickView" |> createNuget)
Target.create "PublishQuickView" (fun _ -> "src" </> "Feliz.Bulma.Extensions.QuickView" |> createNuget)

Target.create "InstallSandbox" (fun _ ->
    printfn "Node version:"
    Tools.node "--version" sandboxPath
    printfn "Yarn version:"
    Tools.yarn "--version" sandboxPath
    Tools.yarn "install --frozen-lockfile" sandboxPath
)

Target.create "RunSandbox" (fun _ -> Tools.yarn "webpack-dev-server" sandboxPath)

"InstallSandbox" ==> "RunSandbox"

Target.runOrDefaultWithArguments "RunSandbox"