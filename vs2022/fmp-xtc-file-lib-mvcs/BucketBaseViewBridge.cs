
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using System.Threading.Tasks;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Bridge;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Bucket的视图桥接层基类（协议部分）
    /// 处理UI的事件
    /// </summary>
    public class BucketBaseViewBridge : IBucketViewBridge
    {

        /// <summary>
        /// 直系服务层
        /// </summary>
        public BucketService? service { get; set; }


        /// <summary>
        /// 处理Make的提交
        /// </summary>
        /// <param name="_dto">BucketMakeRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnMakeSubmit(IDTO _dto)
        {
            BucketMakeRequestDTO? dto = _dto as BucketMakeRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallMake(dto?.message);
        }

        /// <summary>
        /// 处理List的提交
        /// </summary>
        /// <param name="_dto">BucketListRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnListSubmit(IDTO _dto)
        {
            BucketListRequestDTO? dto = _dto as BucketListRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallList(dto?.message);
        }

        /// <summary>
        /// 处理Remove的提交
        /// </summary>
        /// <param name="_dto">BucketRemoveRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnRemoveSubmit(IDTO _dto)
        {
            BucketRemoveRequestDTO? dto = _dto as BucketRemoveRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallRemove(dto?.message);
        }

        /// <summary>
        /// 处理Get的提交
        /// </summary>
        /// <param name="_dto">BucketGetRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnGetSubmit(IDTO _dto)
        {
            BucketGetRequestDTO? dto = _dto as BucketGetRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallGet(dto?.message);
        }

        /// <summary>
        /// 处理Find的提交
        /// </summary>
        /// <param name="_dto">BucketFindRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnFindSubmit(IDTO _dto)
        {
            BucketFindRequestDTO? dto = _dto as BucketFindRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallFind(dto?.message);
        }

        /// <summary>
        /// 处理Search的提交
        /// </summary>
        /// <param name="_dto">BucketSearchRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnSearchSubmit(IDTO _dto)
        {
            BucketSearchRequestDTO? dto = _dto as BucketSearchRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallSearch(dto?.message);
        }

        /// <summary>
        /// 处理Update的提交
        /// </summary>
        /// <param name="_dto">BucketUpdateRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnUpdateSubmit(IDTO _dto)
        {
            BucketUpdateRequestDTO? dto = _dto as BucketUpdateRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallUpdate(dto?.message);
        }

        /// <summary>
        /// 处理ResetToken的提交
        /// </summary>
        /// <param name="_dto">BucketResetTokenRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnResetTokenSubmit(IDTO _dto)
        {
            BucketResetTokenRequestDTO? dto = _dto as BucketResetTokenRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallResetToken(dto?.message);
        }

        /// <summary>
        /// 处理GenerateManifest的提交
        /// </summary>
        /// <param name="_dto">BucketGenerateManifestRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnGenerateManifestSubmit(IDTO _dto)
        {
            BucketGenerateManifestRequestDTO? dto = _dto as BucketGenerateManifestRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallGenerateManifest(dto?.message);
        }

        /// <summary>
        /// 处理Clean的提交
        /// </summary>
        /// <param name="_dto">BucketCleanRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public async Task<Error> OnCleanSubmit(IDTO _dto)
        {
            BucketCleanRequestDTO? dto = _dto as BucketCleanRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallClean(dto?.message);
        }


    }
}
