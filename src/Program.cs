using System.Net;
using System;
using WireMock.RequestBuilders;
using WireMock.Server;
using WireMock.ResponseBuilders;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            using var mock = WireMockServer.Start(8080);
            mock
            .Given(Request.Create().WithPath("/v1/presigned-url").WithHeader("Content-Type", "application/json").UsingPost())
            .RespondWith(Response.Create()
                .WithStatusCode(200)
                .WithHeader("Content-Type", "application/json")
                .WithBodyAsJson(new { Message = "success" }));
            Console.WriteLine("Enter any key to kill mock service.");
            Console.ReadLine();
        }
    }
}
