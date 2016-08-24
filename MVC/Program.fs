open System
open System.IO
open Microsoft.AspNetCore.Hosting

[<EntryPoint>]
let main argv = 
    WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseStartup<AspNetCoreFSharp.Startup>()
        .Build()
        .Run()
    0