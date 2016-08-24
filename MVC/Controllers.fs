namespace AspNetCoreFSharp

open Microsoft.AspNetCore.Mvc

[<Route("api/[controller]")>]
type DefaultController() =
    inherit Controller()

    [<HttpGet>]
    member __.Get() =
        "Hello World"