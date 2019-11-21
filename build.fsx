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

let projectPath = "src" </> "Feliz.Bulma"
let sandboxPath = "sandbox"

Target.create "Clean" (fun _ ->
    [
        projectPath </> "bin"
        projectPath </> "obj"
    ]
    |> Shell.cleanDirs
)        

Target.create "ValidateFemto" (fun _ ->
    Tools.femto "--validate" projectPath
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

Target.create "InstallSandbox" (fun _ ->
    printfn "Node version:"
    Tools.node "--version" sandboxPath
    printfn "Yarn version:"
    Tools.yarn "--version" sandboxPath
    Tools.yarn "install --frozen-lockfile" sandboxPath
)

Target.create "RunSandbox" (fun _ ->
    Tools.yarn "webpack-dev-server" sandboxPath
) 

"InstallSandbox" ==> "RunSandbox"
"Clean" ==> "ValidateFemto" ==> "CreateNuget" ==> "PublishNuget"

Target.runOrDefaultWithArguments "RunSandbox"