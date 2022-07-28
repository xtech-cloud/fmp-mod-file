
namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Object服务层
    /// </summary>
    public class ObjectService : ObjectBaseService
    {
        /// <summary>
        /// 完整名称
        /// </summary>
        public const string NAME = "XTC.FMP.MOD.File.LIB.MVCS.ObjectService";

        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public ObjectService(string _uid) : base(_uid)
        {
        }
    }
}
