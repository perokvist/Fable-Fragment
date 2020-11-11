module App

open Microsoft.AspNetCore
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe
open Giraffe.ViewEngine
open Giraffe.EndpointRouting

let endpoints =
    [
        GET => route "/" (html [] [
            head [] [
                title []  [ str "Giraffe - Hello" ]
            ]
            body [] [ str "Hello world!"]
        ] |> htmlView)
        GET => route "/pages/product" ([HtmlViews.productView { Id = 40; Price = 2500; Title = "Test" }] |> HtmlViews.layout |> htmlView)
        GET => route "/fragments/product" (HtmlViews.productView { Id = 40; Price = 2500; Title = "Test" } |> htmlView)
    ]

let notFoundMiddleware =
    "Not Found"
    |> text
    |> RequestErrors.notFound
    |> GiraffeMiddleware.create

[<EntryPoint>]
let main args =
    WebHost
        .CreateDefaultBuilder(args)
        .UseKestrel()
        .Configure(fun builder -> 
            builder
                .UseRouting()
                .UseEndpoints(fun e -> e.MapGiraffeEndpoints(endpoints))
                .UseStaticFiles()
                .Use(notFoundMiddleware) 
                |> ignore)
        .ConfigureServices(fun services -> 
                services
                    .AddRouting()
                    .AddGiraffe()
                    |> ignore)
        .Build()
        .Run()
    0