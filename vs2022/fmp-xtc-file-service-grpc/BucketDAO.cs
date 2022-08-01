using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace XTC.FMP.MOD.File.App.Service
{
    public class BucketDAO : DAO<BucketEntity>
    {
        public BucketDAO(IOptions<DatabaseSettings> _settings)
            : base(_settings, "Bucket")
        {
        }

        public async Task<BucketEntity?> GetWithNameAsync(string _name) =>
             await collection_.Find(x => x.Name == _name).FirstOrDefaultAsync();

        /// <summary>
        /// 条件取且
        /// </summary>
        /// <param name="_offset"></param>
        /// <param name="_count"></param>
        /// <param name="_name"></param>
        /// <param name="_remark"></param>
        /// <returns></returns>
        public virtual async Task<List<BucketEntity>> SearchAsync(int _offset, int _count, string _name, string _remark)
        {
            var filter = Builders<BucketEntity>.Filter.Where(x =>
                (string.IsNullOrWhiteSpace(_name) || null != x.Name && x.Name.ToLower().Contains(_name.ToLower())) &&
                (string.IsNullOrWhiteSpace(_remark) || null != x.Remark && x.Remark.ToLower().Contains(_remark.ToLower()))
            );
            return await collection_.Find(filter).Skip((int)_offset).Limit((int)_count).ToListAsync();
        }

        public LIB.Proto.BucketEntity ToProtoEntity(BucketEntity _entity)
        {
            return new LIB.Proto.BucketEntity
            {
                Uuid = _entity.Uuid.ToString(),
                Name = _entity.Name,
                TotalSize = _entity.TotalSize,
                UsedSize = _entity.UsedSize,
                Remark = _entity.Remark ?? "",
                Storage = new LIB.Proto.Storage
                {
                    AccessKey = _entity.Storage?.AccessKey ?? "",
                    AccessSecret = _entity.Storage?.AccessSecret ?? "",
                    Address = _entity.Storage?.Address ?? "",
                    Driver = _entity.Storage?.Driver ?? "",
                    Mode = _entity.Storage?.Mode ?? "",
                    Scope = _entity.Storage?.Scope ?? "",
                    Url = _entity.Storage?.Url ?? "",
                },
            };
        }

        public BucketEntity FromProtoEntity(LIB.Proto.BucketEntity _entity)
        {
            return new BucketEntity
            {
                Name = _entity.Name,
                Remark = _entity.Remark,
                TotalSize = _entity.TotalSize,
                UsedSize = _entity.UsedSize,
                Storage = new Storage
                {
                    AccessKey = _entity.Storage.AccessKey,
                    AccessSecret = _entity.Storage.AccessSecret,
                    Address = _entity.Storage.Address,
                    Driver = _entity.Storage.Driver,
                    Mode = _entity.Storage.Mode,
                    Scope = _entity.Storage.Scope,
                    Url = _entity.Storage.Url,
                }
            };
        }
    }
}
