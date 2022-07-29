namespace XTC.FMP.MOD.File.App.Service
{
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
    }
}
