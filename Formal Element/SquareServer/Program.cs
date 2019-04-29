using System;
using Grpc.Core;
using Com.Example.Grpc;

namespace SquareServer
{
    class Program
    {
        const string Host = "localhost";
        const int Port = 50051;

        public static void Main(string[] args)
        {
            // Build a server
            var server = new Server
            {
                Services = { SquareService.BindService(new SquareServiceImpl()) },
                Ports = { new ServerPort(Host, Port, ServerCredentials.Insecure) }
            };

            // Start server
            server.Start();

            Console.WriteLine("SquareServer listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
