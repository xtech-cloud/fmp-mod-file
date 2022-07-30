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
    }
}
