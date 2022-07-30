
using Grpc.Core;
using System.Threading.Tasks;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.App.Service
{
    public class BucketService : BucketServiceBase
    {
        private readonly BucketDAO  bucketDAO_;

         /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>
        /// 支持多个参数，均为自动注入，注入点位于MyProgram.PreBuild
        /// </remarks>
        /// <param name="_yourDAO">自动注入的数据操作对象</param>
        public BucketService(BucketDAO _bucketDAO)
        {
            bucketDAO_ = _bucketDAO;
        }

        public override async Task<UuidResponse> Make(BucketMakeRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredString(_request.Name, "Name");
                ArgumentChecker.CheckRequiredNumber((int)_request.Capacity, "Capacity");
            }
            catch(ArgumentException ex)
            {
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = 1, Message = ex.Message },
                };
            }

            var bucket =  await bucketDAO_.GetWithNameAsync(_request.Name);
            if(null != bucket)
            {
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = 2, Message = "bucket exists" },
                };
            }

            bucket = new BucketEntity();
            bucket.Uuid = Guid.NewGuid();
            bucket.Name = _request.Name;
            bucket.TotalSize = _request.Capacity;
            await bucketDAO_.CreateAsync(bucket);

            return new UuidResponse
            {
                Status = new LIB.Proto.Status(),
                Uuid = bucket.Uuid.ToString(),
            };
        }
    }
}
