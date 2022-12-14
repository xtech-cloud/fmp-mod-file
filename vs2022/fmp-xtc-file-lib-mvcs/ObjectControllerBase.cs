
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Object控制层基类
    /// </summary>
    public class ObjectControllerBase : Controller
    {
        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public ObjectControllerBase(string _uid) : base(_uid)
        {

        }


        /// <summary>
        /// 更新Prepare的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Prepare的回复</param>
        public void UpdateProtoPrepare(ObjectModel.ObjectStatus? _status, ObjectPrepareResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectPrepareResponseDTO? dto = new ObjectPrepareResponseDTO(_response);
            getView()?.RefreshProtoPrepare(err, dto);
        }

        /// <summary>
        /// 更新Flush的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Flush的回复</param>
        public void UpdateProtoFlush(ObjectModel.ObjectStatus? _status, UuidResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            UuidResponseDTO? dto = new UuidResponseDTO(_response);
            getView()?.RefreshProtoFlush(err, dto);
        }

        /// <summary>
        /// 更新Get的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Get的回复</param>
        public void UpdateProtoGet(ObjectModel.ObjectStatus? _status, ObjectGetResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectGetResponseDTO? dto = new ObjectGetResponseDTO(_response);
            getView()?.RefreshProtoGet(err, dto);
        }

        /// <summary>
        /// 更新Find的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Find的回复</param>
        public void UpdateProtoFind(ObjectModel.ObjectStatus? _status, ObjectFindResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectFindResponseDTO? dto = new ObjectFindResponseDTO(_response);
            getView()?.RefreshProtoFind(err, dto);
        }

        /// <summary>
        /// 更新Remove的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Remove的回复</param>
        public void UpdateProtoRemove(ObjectModel.ObjectStatus? _status, UuidResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            UuidResponseDTO? dto = new UuidResponseDTO(_response);
            getView()?.RefreshProtoRemove(err, dto);
        }

        /// <summary>
        /// 更新List的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">List的回复</param>
        public void UpdateProtoList(ObjectModel.ObjectStatus? _status, ObjectListResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectListResponseDTO? dto = new ObjectListResponseDTO(_response);
            getView()?.RefreshProtoList(err, dto);
        }

        /// <summary>
        /// 更新Search的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Search的回复</param>
        public void UpdateProtoSearch(ObjectModel.ObjectStatus? _status, ObjectSearchResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectSearchResponseDTO? dto = new ObjectSearchResponseDTO(_response);
            getView()?.RefreshProtoSearch(err, dto);
        }

        /// <summary>
        /// 更新Publish的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Publish的回复</param>
        public void UpdateProtoPublish(ObjectModel.ObjectStatus? _status, ObjectPublishResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectPublishResponseDTO? dto = new ObjectPublishResponseDTO(_response);
            getView()?.RefreshProtoPublish(err, dto);
        }

        /// <summary>
        /// 更新Preview的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Preview的回复</param>
        public void UpdateProtoPreview(ObjectModel.ObjectStatus? _status, ObjectPreviewResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectPreviewResponseDTO? dto = new ObjectPreviewResponseDTO(_response);
            getView()?.RefreshProtoPreview(err, dto);
        }

        /// <summary>
        /// 更新Retract的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Retract的回复</param>
        public void UpdateProtoRetract(ObjectModel.ObjectStatus? _status, UuidResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            UuidResponseDTO? dto = new UuidResponseDTO(_response);
            getView()?.RefreshProtoRetract(err, dto);
        }

        /// <summary>
        /// 更新ConvertFromBase64的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">ConvertFromBase64的回复</param>
        public void UpdateProtoConvertFromBase64(ObjectModel.ObjectStatus? _status, ObjectConvertFromBase64Response _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectConvertFromBase64ResponseDTO? dto = new ObjectConvertFromBase64ResponseDTO(_response);
            getView()?.RefreshProtoConvertFromBase64(err, dto);
        }

        /// <summary>
        /// 更新ConvertFromUrl的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">ConvertFromUrl的回复</param>
        public void UpdateProtoConvertFromUrl(ObjectModel.ObjectStatus? _status, ObjectConvertFromUrlResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            ObjectConvertFromUrlResponseDTO? dto = new ObjectConvertFromUrlResponseDTO(_response);
            getView()?.RefreshProtoConvertFromUrl(err, dto);
        }


        /// <summary>
        /// 获取直系视图层
        /// </summary>
        /// <returns>视图层</returns>
        protected ObjectView? getView()
        {
            if(null == view_)
                view_ = findView(ObjectView.NAME) as ObjectView;
            return view_;
        }

        /// <summary>
        /// 直系视图层
        /// </summary>
        private ObjectView? view_;
    }
}
