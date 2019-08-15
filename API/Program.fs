namespace API

open System
open System.Collections.Generic
open System.IO
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Logging

module Program =
    let exitCode = 0

    let CreateWebHostBuilder () =
        WebHost
            .CreateDefaultBuilder()
            .UseKestrel(fun options -> options.ListenLocalhost(80))
            .UseStartup<Startup>();

    [<EntryPoint>]
    let main _ =

        CreateWebHostBuilder().Build().Run()

        exitCode
