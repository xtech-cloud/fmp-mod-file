
namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Bucket服务层
    /// </summary>
    public class BucketService : BucketBaseService
    {
        /// <summary>
        /// 完整名称
        /// </summary>
        public const string NAME = "XTC.FMP.MOD.File.LIB.MVCS.BucketService";

        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public BucketService(string _uid) : base(_uid)
        {
        }
    }
}
