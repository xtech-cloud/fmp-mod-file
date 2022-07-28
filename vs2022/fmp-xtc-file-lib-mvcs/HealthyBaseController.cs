
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Healthy控制层基类
    /// </summary>
    public class HealthyBaseController : Controller
    {
        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public HealthyBaseController(string _uid) : base(_uid)
        {

        }


        /// <summary>
        /// 更新Echo的数据
        /// </summary>
        /// <param name="_status">直系状态</param>
        /// <param name="_response">Echo的回复</param>
        public void UpdateProtoEcho(HealthyModel.HealthyStatus? _status, HealthyEchoResponse _response)
        {
            Error err = new Error(_response.Status.Code, _response.Status.Message);
            HealthyEchoResponseDTO? dto = new HealthyEchoResponseDTO(_response);
            getView()?.RefreshProtoEcho(err, dto);
        }


        /// <summary>
        /// 获取直系视图层
        /// </summary>
        /// <returns>视图层</returns>
        protected HealthyView? getView()
        {
            if(null == view_)
                view_ = findView(HealthyView.NAME) as HealthyView;
            return view_;
        }

        /// <summary>
        /// 直系视图层
        /// </summary>
        private HealthyView? view_;
    }
}
