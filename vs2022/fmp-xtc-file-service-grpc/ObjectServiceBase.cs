
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
    public class ObjectServiceBase : LIB.Proto.Object.ObjectBase
    {
    

        public override async Task<ObjectPrepareResponse> Prepare(ObjectPrepareRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectPrepareResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<UuidResponse> Flush(ObjectFlushRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new UuidResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectGetResponse> Get(ObjectGetRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectGetResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectFindResponse> Find(ObjectFindRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectFindResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<UuidResponse> Remove(ObjectRemoveRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new UuidResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectListResponse> List(ObjectListRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectListResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectSearchResponse> Search(ObjectSearchRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectSearchResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectPublishResponse> Publish(ObjectPublishRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectPublishResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectPreviewResponse> Preview(ObjectPreviewRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectPreviewResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<UuidResponse> Retract(ObjectRetractRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new UuidResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectConvertFromBase64Response> ConvertFromBase64(ObjectConvertFromBase64Request _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectConvertFromBase64Response {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        public override async Task<ObjectConvertFromUrlResponse> ConvertFromUrl(ObjectConvertFromUrlRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new ObjectConvertFromUrlResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

    }
}

