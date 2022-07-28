
using XTC.FMP.LIB.MVCS;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    /// <summary>
    /// Object数据层
    /// </summary>
    public class ObjectModel : ObjectBaseModel
    {
        /// <summary>
        /// 完整名称
        /// </summary>
        public const string NAME = "XTC.FMP.MOD.File.LIB.MVCS.ObjectModel";

        /// <summary>
        /// Object状态
        /// </summary>
        public class ObjectStatus : Model.Status
        {
        }

        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        public ObjectModel(string _uid) : base(_uid)
        {
        }

        protected override void preSetup()
        {
            base.preSetup();

            // 实例化直系状态
            Error err;
            status_ = spawnStatus<ObjectStatus>(this.getUID() + ".Status", out err);
            if (0 != err.getCode())
            {
                getLogger()?.Error(err.getMessage());
            }
            else
            {
                getLogger()?.Trace("setup {0}", this.getUID() + ".Status");
            }
        }

        protected override void preDismantle()
        {
            base.preDismantle();

            // 销毁直系状态
            Error err;
            killStatus(this.getUID() + ".Status", out err);
            if (0 != err.getCode())
            {
                getLogger()?.Error(err.getMessage());
            }
        }

    }
}


