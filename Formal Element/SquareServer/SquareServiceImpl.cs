using Com.Example.Grpc;
using Grpc.Core;
using System.Threading.Tasks;
using System;

namespace SquareServer
{
    // SquareServiceImpl provides an implementation of the SquareService service
    public class SquareServiceImpl : SquareService.SquareServiceBase
    {
        public override Task<SquareResponse> getSquare(SquareRequest request, ServerCallContext context)
        {
            var opResult = request.RequestValue * request.RequestValue;
            Console.WriteLine("|Client: " + context.Peer + " |Value: " + request.RequestValue + " |Result: " + opResult);
            return Task.FromResult(new SquareResponse { ResponseValue = opResult });
        }
    }
}
