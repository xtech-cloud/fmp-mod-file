
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Healthy数据层基类
    /// </summary>
    public class HealthyBaseModel : Model
    {
        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public HealthyBaseModel(string _uid) : base(_uid)
        {

        }


        /// <summary>
        /// 更新Echo的数据
        /// </summary>
        /// <param name="_response">Echo的回复</param>
        public void UpdateProtoEcho(HealthyEchoResponse _response)
        {
            getController()?.UpdateProtoEcho(status_ as HealthyModel.HealthyStatus, _response);
        }


        /// <summary>
        /// 获取直系控制层
        /// </summary>
        /// <returns>控制层</returns>
        protected HealthyController? getController()
        {
            if(null == controller_)
                controller_ = findController(HealthyController.NAME) as HealthyController;
            return controller_;
        }

        /// <summary>
        /// 直系控制层
        /// </summary>
        private HealthyController? controller_;
    }
}


