
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Bucket数据层基类
    /// </summary>
    public class BucketModelBase : Model
    {
        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public BucketModelBase(string _uid) : base(_uid)
        {

        }


        /// <summary>
        /// 更新Make的数据
        /// </summary>
        /// <param name="_response">Make的回复</param>
        public void UpdateProtoMake(UuidResponse _response)
        {
            getController()?.UpdateProtoMake(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新List的数据
        /// </summary>
        /// <param name="_response">List的回复</param>
        public void UpdateProtoList(BucketListResponse _response)
        {
            getController()?.UpdateProtoList(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新Remove的数据
        /// </summary>
        /// <param name="_response">Remove的回复</param>
        public void UpdateProtoRemove(UuidResponse _response)
        {
            getController()?.UpdateProtoRemove(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新Get的数据
        /// </summary>
        /// <param name="_response">Get的回复</param>
        public void UpdateProtoGet(BucketGetResponse _response)
        {
            getController()?.UpdateProtoGet(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新Find的数据
        /// </summary>
        /// <param name="_response">Find的回复</param>
        public void UpdateProtoFind(BucketFindResponse _response)
        {
            getController()?.UpdateProtoFind(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新Search的数据
        /// </summary>
        /// <param name="_response">Search的回复</param>
        public void UpdateProtoSearch(BucketSearchResponse _response)
        {
            getController()?.UpdateProtoSearch(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新Update的数据
        /// </summary>
        /// <param name="_response">Update的回复</param>
        public void UpdateProtoUpdate(UuidResponse _response)
        {
            getController()?.UpdateProtoUpdate(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新ResetToken的数据
        /// </summary>
        /// <param name="_response">ResetToken的回复</param>
        public void UpdateProtoResetToken(UuidResponse _response)
        {
            getController()?.UpdateProtoResetToken(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新GenerateManifest的数据
        /// </summary>
        /// <param name="_response">GenerateManifest的回复</param>
        public void UpdateProtoGenerateManifest(BucketGenerateManifestResponse _response)
        {
            getController()?.UpdateProtoGenerateManifest(status_ as BucketModel.BucketStatus, _response);
        }

        /// <summary>
        /// 更新Clean的数据
        /// </summary>
        /// <param name="_response">Clean的回复</param>
        public void UpdateProtoClean(UuidResponse _response)
        {
            getController()?.UpdateProtoClean(status_ as BucketModel.BucketStatus, _response);
        }


        /// <summary>
        /// 获取直系控制层
        /// </summary>
        /// <returns>控制层</returns>
        protected BucketController? getController()
        {
            if(null == controller_)
                controller_ = findController(BucketController.NAME) as BucketController;
            return controller_;
        }

        /// <summary>
        /// 直系控制层
        /// </summary>
        private BucketController? controller_;
    }
}


