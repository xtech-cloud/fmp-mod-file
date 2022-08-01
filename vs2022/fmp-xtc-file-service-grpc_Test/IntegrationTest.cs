
using Grpc.Net.Client;
using XTC.FMP.MOD.File.LIB.Proto;

public class IntegrationTest : IntegrationTestBase
{
    [Fact]
    public override async Task Test()
    {
        var channel = GrpcChannel.ForAddress("https://localhost:19000", new GrpcChannelOptions());

        var clientBucket = new Bucket.BucketClient(channel);

        var bucketUUID = Guid.NewGuid().ToString(); 
        {
            var req = new BucketMakeRequest();
            req.Name = "test";
            req.Capacity = 1024000000;
            var response = await clientBucket.MakeAsync(req);
            Assert.Equal(0, response.Status.Code);
            bucketUUID = response.Uuid;
        }

        {
            var req = new BucketRemoveRequest();
            req.Uuid = bucketUUID;
            var response = await clientBucket.RemoveAsync(req);
            Assert.Equal(0, response.Status.Code);
        }
    }
}
