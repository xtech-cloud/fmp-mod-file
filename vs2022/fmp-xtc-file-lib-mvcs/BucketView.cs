
using XTC.FMP.LIB.MVCS;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Bucket视图层
    /// </summary>
    public class BucketView : BucketViewBase
    {
        /// <summary>
        /// 完整名称
        /// </summary>
        public const string NAME = "XTC.FMP.MOD.File.LIB.MVCS.BucketView";

        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public BucketView(string _uid) : base(_uid)
        {
        }
    }
}


