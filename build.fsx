open Fake.IO

#r "paket: groupref Build //"

#if !FAKE
#load ".fake/build.fsx/intellisense_lazy.fsx"
#endif

open System.IO
open Fake.Core
open Fake.DotNet
open Fake.IO.FileSystemOperators
open Fake.Core.TargetOperators

module Tools =
    let private runTool cmd args workingDir =
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

let projectPath = "src" </> "Feliz.Bulma"

Target.create "Clean" (fun _ ->
    [
        projectPath </> "bin"
        projectPath </> "obj"
    ]
    |> Shell.cleanDirs
)        

Target.create "CreateNuget" (fun _ ->
    Tools.dotnet "restore --no-cache" projectPath
    Tools.dotnet "pack -c Release" projectPath
)

Target.create "PublishNuget" (fun _ ->
    let nugetKey =
        match Environment.environVarOrNone "NUGET_KEY" with
        | Some nugetKey -> nugetKey
        | None -> failwith "The Nuget API key must be set in a NUGET_KEY environmental variable"
    let nupkg =
        Directory.GetFiles(projectPath </> "bin" </> "Release")
        |> Seq.head
        |> Path.GetFullPath
    Tools.dotnet (sprintf "nuget push %s -s nuget.org -k %s" nupkg nugetKey) projectPath
)

"Clean" ==> "CreateNuget" ==> "PublishNuget"

Target.runOrDefaultWithArguments ""