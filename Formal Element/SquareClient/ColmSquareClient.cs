using System;
using Grpc.Core;
using Com.Example.Grpc;

namespace SquareClient
{
    public class ColmSquareClient
    {
        const string Host = "localhost";
        const int Port = 50051;

        public static void Main(string[] args)
        {
            //Do Nothing
        }


        public double getSquare(double value)
        {
            // Create a channel
            var channel = new Channel(Host + ":" + Port, ChannelCredentials.Insecure);

            // Create a client with the channel
            var client = new SquareService.SquareServiceClient(channel);

            // Create a request
            var request = new SquareRequest{
                RequestValue = value
            };

            // Send the request
            var response = client.getSquare(request);

            return response.ResponseValue;
        }
    }
}
