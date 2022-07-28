
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using Grpc.Core;
using System.Threading.Tasks;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.App.Service
{
    /// <summary>
    /// Bucket基类
    /// </summary>
    public class BucketBaseService : Bucket.BucketBase
    {

        public override Task<UuidResponse> Make(BucketMakeRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<BucketListResponse> List(BucketListRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new BucketListResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<UuidResponse> Remove(BucketRemoveRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<BucketGetResponse> Get(BucketGetRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new BucketGetResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<BucketFindResponse> Find(BucketFindRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new BucketFindResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<BucketSearchResponse> Search(BucketSearchRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new BucketSearchResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<UuidResponse> Update(BucketUpdateRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<UuidResponse> ResetToken(BucketResetTokenRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<BucketGenerateManifestResponse> GenerateManifest(BucketGenerateManifestRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new BucketGenerateManifestResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<UuidResponse> Clean(BucketCleanRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

    }
}

