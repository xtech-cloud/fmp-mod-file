
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using Grpc.Core;
using System.Threading.Tasks;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.App.Service
{
    /// <summary>
    /// Object基类
    /// </summary>
    public class ObjectBaseService : LIB.Proto.Object.ObjectBase
    {

        public override Task<ObjectPrepareResponse> Prepare(ObjectPrepareRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectPrepareResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<UuidResponse> Flush(ObjectFlushRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectGetResponse> Get(ObjectGetRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectGetResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectFindResponse> Find(ObjectFindRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectFindResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<UuidResponse> Remove(ObjectRemoveRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectListResponse> List(ObjectListRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectListResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectSearchResponse> Search(ObjectSearchRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectSearchResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectPublishResponse> Publish(ObjectPublishRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectPublishResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectPreviewResponse> Preview(ObjectPreviewRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectPreviewResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<UuidResponse> Retract(ObjectRetractRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new UuidResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectConvertFromBase64Response> ConvertFromBase64(ObjectConvertFromBase64Request _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectConvertFromBase64Response
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

        public override Task<ObjectConvertFromUrlResponse> ConvertFromUrl(ObjectConvertFromUrlRequest _request, ServerCallContext _context)
        {
            return Task.FromResult(new ObjectConvertFromUrlResponse
            {
                Status = new LIB.Proto.Status() { Code=-1, Message="Not Implemented"},
            });
        }

    }
}
