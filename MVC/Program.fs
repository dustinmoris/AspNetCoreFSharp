open System
open System.IO
open Microsoft.AspNetCore.Hosting

[<EntryPoint>]
let main argv = 
    let host =
        WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<AspNetCoreFSharp.Startup>()
            .Build()
    host.Run()
    0