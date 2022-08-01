namespace XTC.FMP.MOD.File.App.Service
{
    public class Storage
    {
        /// <summary>
        /// 访问键
        /// </summary>
        public string? AccessKey { get; set; }

        /// <summary>
        /// 访问密钥
        /// </summary>
        public string? AccessSecret { get; set; }

        /// <summary>
        /// 内部连接地址
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// 驱动
        /// </summary>
        public string? Driver { get; set; }

        /// <summary>
        /// 模式，hash或path
        /// </summary>
        public string? Mode { get; set; }

        /// <summary>
        /// 作用域，类似与桶名
        /// </summary>
        public string? Scope { get; set; }

        /// <summary>
        /// 外部访问地址
        /// </summary>
        public string? Url { get; set; }
    }

    public class BucketEntity : Entity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 总大小
        /// </summary>
        public ulong TotalSize { get; set; }

        /// <summary>
        /// 已用大小
        /// </summary>
        public ulong UsedSize { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }

        /// <summary>
        /// 存储引擎
        /// </summary>
        public Storage? Storage { get; set; }
    }
}
