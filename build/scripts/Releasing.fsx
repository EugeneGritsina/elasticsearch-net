﻿#I @"../../packages/build/FAKE/tools"
#I @"../../packages/build/FSharp.Data/lib/net40"
#r @"FakeLib.dll"
#r @"FSharp.Data.dll"
#load @"Paths.fsx"
#load @"Projects.fsx"
#load @"Versioning.fsx"
#load @"Building.fsx"
open System
open System.IO
open Fake 
open Paths
open Projects
open Versioning
open Building
open FSharp.Data

// TODO: Use a complete project.json skeleton
type ProjectJson = JsonProvider<"../../src/Nest/project.json">

type Release() = 
    static let nugetPack = fun (projectName: ProjectName) ->
        let name = projectName.Nuget;
        CreateDir Paths.NugetOutput
        let package = (sprintf @"build\%s.nuspec" name)
        let packageContents = ReadFileAsString package
        let re = @"(?<start>\<version\>|""(Elasticsearch.Net|Nest)"" version="")[^""><]+(?<end>\<\/version\>|"")"
        let replacedContents = regex_replace re (sprintf "${start}%s${end}" Versioning.FileVersion) packageContents
        WriteStringToFile false package replacedContents
    
        let dir = sprintf "%s/%s/" Paths.BuildOutput name
        let nugetOutFile =  Paths.Output(sprintf "%s/%s.%s.nupkg" name name Versioning.FileVersion);
        NuGetPack (fun p ->
          {p with 
            Version = Versioning.FileVersion
            WorkingDir = "build" 
            OutputPath = dir
          })
          package
        traceFAKE "%s" dir
        MoveFile Paths.NugetOutput nugetOutFile

    static let updateVersion project =
        CreateDir Paths.NugetOutput
        use file = File.Open (project, FileMode.Open)
        let doc = ProjectJson.Load file

        let newDoc = ProjectJson.Root(
                        doc.Authors, 
                        doc.Owners, 
                        doc.ProjectUrl, 
                        doc.LicenseUrl,
                        doc.RequireLicenseAcceptance, 
                        doc.IconUrl, 
                        doc.Summary, 
                        doc.Description, 
                        doc.Title, 
                        doc.Tags,
                        doc.Copyright,
                        Versioning.FileVersion,
                        doc.CompilationOptions,
                        doc.Configurations,
                        doc.Dependencies,
                        doc.Commands,
                        doc.Frameworks)
        
        file.Close ()
        File.Delete project
        use writer = new StreamWriter(File.Open (project, FileMode.Create))
        newDoc.JsonValue.WriteTo(writer, JsonSaveOptions.None)

    static member PackAll() =
        let projects = !! "src/Nest/project.json" 
                       ++ "src/Elasticsearch.Net/project.json"

        // update versions
        projects |> Seq.iter updateVersion

        // build nuget packages
        projects
        |> Seq.map DirectoryName
        |> Seq.iter(fun project -> 
            Tooling.Dnu.Exec Build.BuildFailure project ["pack"; (Paths.Quote project); "--configuration Release"; "--quiet"])

        // move to nuget output
        projects
        |> Seq.iter(fun project ->
            let projectName = (project |> DirectoryName |> directoryInfo).Name
            let srcFolder = Paths.BinFolder(projectName)
            let package = sprintf "%s/%s.%s.nupkg" srcFolder projectName Versioning.FileVersion
            MoveFile Paths.NugetOutput package
        )