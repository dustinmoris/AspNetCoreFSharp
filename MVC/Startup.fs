namespace AspNetCoreFSharp

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Logging

type Startup() =

    let configuration = 
        ConfigurationBuilder().AddEnvironmentVariables().Build()

    // This method gets called by the runtime.
    // Use this method to add dependencies to the container.
    member __.ConfigureServices(container : IServiceCollection) =
        container.AddMvc() |> ignore

    // This method gets called by the runtime.
    // Use this method to configure the HTTP request pipeline.
    member __.Configure (app : IApplicationBuilder)
                        (env : IHostingEnvironment)
                        (loggerFactory : ILoggerFactory) =
        app.UseMvc() |> ignore