
using XTC.FMP.LIB.MVCS;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Object视图层
    /// </summary>
    public class ObjectView : ObjectViewBase
    {
        /// <summary>
        /// 完整名称
        /// </summary>
        public const string NAME = "XTC.FMP.MOD.File.LIB.MVCS.ObjectView";

        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public ObjectView(string _uid) : base(_uid)
        {
        }
    }
}


