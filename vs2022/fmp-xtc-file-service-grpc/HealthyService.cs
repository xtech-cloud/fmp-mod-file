
using Grpc.Core;
using System.Threading.Tasks;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.App.Service
{
    public class HealthyService : HealthyServiceBase
    {
        public override async Task<HealthyEchoResponse> Echo(HealthyEchoRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new HealthyEchoResponse
            {
                Status = new LIB.Proto.Status(),
                Msg = _request.Msg,
            });;
        }
    }
}
