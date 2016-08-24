# ASP.NET Core web application in FSharp

This project contains two different empty ASP.NET Core web application templates written in F#.

The first one is a complete empty Hello World template and the second is an empty ASP.NET Core MVC Web API template.

## Why?

I created those two templates because the command `dotnet new --lang fsharp` doesn't support the flag `--type web` at the moment, even though it is possible as shown by this project. 

## How to get it running

Run `dotnet restore` and then `dotnet run` and then visit `http://localhost:5000` or `http://localhost:5000/api/default` to get a default "Hello World" response.