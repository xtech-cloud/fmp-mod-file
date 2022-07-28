
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using System.Threading.Tasks;
using Grpc.Net.Client;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Bucket服务层基类
    /// </summary>
    public class BucketBaseService : Service
    {
        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public BucketBaseService(string _uid) : base(_uid)
        {

        }

        /// <summary>
        /// 注入GRPC通道
        /// </summary>
        /// <param name="_channel">GRPC通道</param>
        public void InjectGrpcChannel(GrpcChannel? _channel)
        {
            grpcChannel_ = _channel;
        }


        /// <summary>
        /// 调用Make
        /// </summary>
        /// <param name="_request">Make的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallMake(BucketMakeRequest? _request)
        {
            getLogger()?.Trace("Call Make ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.MakeAsync(_request);
            getModel()?.UpdateProtoMake(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用List
        /// </summary>
        /// <param name="_request">List的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallList(BucketListRequest? _request)
        {
            getLogger()?.Trace("Call List ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.ListAsync(_request);
            getModel()?.UpdateProtoList(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用Remove
        /// </summary>
        /// <param name="_request">Remove的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallRemove(BucketRemoveRequest? _request)
        {
            getLogger()?.Trace("Call Remove ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.RemoveAsync(_request);
            getModel()?.UpdateProtoRemove(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用Get
        /// </summary>
        /// <param name="_request">Get的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallGet(BucketGetRequest? _request)
        {
            getLogger()?.Trace("Call Get ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.GetAsync(_request);
            getModel()?.UpdateProtoGet(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用Find
        /// </summary>
        /// <param name="_request">Find的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallFind(BucketFindRequest? _request)
        {
            getLogger()?.Trace("Call Find ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.FindAsync(_request);
            getModel()?.UpdateProtoFind(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用Search
        /// </summary>
        /// <param name="_request">Search的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallSearch(BucketSearchRequest? _request)
        {
            getLogger()?.Trace("Call Search ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.SearchAsync(_request);
            getModel()?.UpdateProtoSearch(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用Update
        /// </summary>
        /// <param name="_request">Update的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallUpdate(BucketUpdateRequest? _request)
        {
            getLogger()?.Trace("Call Update ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.UpdateAsync(_request);
            getModel()?.UpdateProtoUpdate(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用ResetToken
        /// </summary>
        /// <param name="_request">ResetToken的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallResetToken(BucketResetTokenRequest? _request)
        {
            getLogger()?.Trace("Call ResetToken ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.ResetTokenAsync(_request);
            getModel()?.UpdateProtoResetToken(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用GenerateManifest
        /// </summary>
        /// <param name="_request">GenerateManifest的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallGenerateManifest(BucketGenerateManifestRequest? _request)
        {
            getLogger()?.Trace("Call GenerateManifest ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.GenerateManifestAsync(_request);
            getModel()?.UpdateProtoGenerateManifest(response);
            return Error.OK;
        }

        /// <summary>
        /// 调用Clean
        /// </summary>
        /// <param name="_request">Clean的请求</param>
        /// <returns>错误</returns>
        public async Task<Error> CallClean(BucketCleanRequest? _request)
        {
            getLogger()?.Trace("Call Clean ...");
            if(null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }
            var client = getGrpcClient();
            if (null == client)
            {
                return Error.NewNullErr("client is null");
            }

            var response = await client.CleanAsync(_request);
            getModel()?.UpdateProtoClean(response);
            return Error.OK;
        }


        /// <summary>
        /// 获取直系数据层
        /// </summary>
        /// <returns>数据层</returns>
        protected BucketModel? getModel()
        {
            if(null == model_)
                model_ = findModel(BucketModel.NAME) as BucketModel;
            return model_;
        }

        /// <summary>
        /// 获取GRPC客户端
        /// </summary>
        /// <returns>GRPC客户端</returns>
        protected Bucket.BucketClient? getGrpcClient()
        {
            if (null == grpcChannel_)
                return null;

            if(null == clientBucket_)
            {
                clientBucket_ = new Bucket.BucketClient(grpcChannel_);
            }
            return clientBucket_;
        }

        /// <summary>
        /// GRPC客户端
        /// </summary>
        protected Bucket.BucketClient? clientBucket_;

        /// <summary>
        /// GRPC通道
        /// </summary>
        protected GrpcChannel? grpcChannel_;

        /// <summary>
        /// 直系数据层
        /// </summary>
        private BucketModel? model_;
    }

}