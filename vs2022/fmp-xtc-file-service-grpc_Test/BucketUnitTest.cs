
using XTC.FMP.MOD.File.LIB.Proto;

public class BucketTest : BucketUnitTestBase
{
    public BucketTest(TestFixture _testFixture)
        : base(_testFixture)
    {
    }


    public override async Task MakeTest()
    {
        var request = new BucketMakeRequest();
        // 缺少Name
        var response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);
        // 缺少Cpacity
        request.Name = "test";
        response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);
        // 成功
        request.Capacity = 10240000;
        response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        // 已存在
        response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(-302, response.Status.Code);

    }

    public override async Task ListTest()
    {
        // 创建10个
        for (int i = 0; i < 10; i++)
        {
            var requestMake = new BucketMakeRequest();
            requestMake.Name = String.Format("test-{0}", i + 1);
            requestMake.Capacity = 10240000;
            var responseMake = await fixture_.getServiceBucket().Make(requestMake, fixture_.context);
            Assert.Equal(0, responseMake.Status.Code);
        }

        var request = new BucketListRequest();
        // 缺少count
        var response = await fixture_.getServiceBucket().List(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);
        // 10个
        request.Count = 10;
        response = await fixture_.getServiceBucket().List(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        Assert.Equal(10, response.Entity.Count);
        // 4-7个
        request.Offset = 3;
        request.Count = 4;
        response = await fixture_.getServiceBucket().List(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        Assert.Equal(4, response.Entity.Count);
        Assert.Equal("test-4", response.Entity[0].Name);
        Assert.Equal("test-7", response.Entity[3].Name);
        // 8-10个
        request.Offset = 7;
        request.Count = 10;
        response = await fixture_.getServiceBucket().List(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        Assert.Equal(3, response.Entity.Count);
        Assert.Equal("test-8", response.Entity[0].Name);
        // 超出范围
        request.Offset = 12;
        request.Count = 10;
        response = await fixture_.getServiceBucket().List(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        Assert.Empty(response.Entity);
    }

    public override async Task RemoveTest()
    {
        var requestMake = new BucketMakeRequest();
        requestMake.Name = "test-remove";
        requestMake.Capacity = 10240000;
        var responseMake = await fixture_.getServiceBucket().Make(requestMake, fixture_.context);
        Assert.Equal(0, responseMake.Status.Code);

        // 缺少Uuid参数
        var request = new BucketRemoveRequest();
        var response = await fixture_.getServiceBucket().Remove(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);

        // 存在
        request.Uuid = responseMake.Uuid;
        response = await fixture_.getServiceBucket().Remove(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);

        // 不存在
        request.Uuid = responseMake.Uuid;
        response = await fixture_.getServiceBucket().Remove(request, fixture_.context);
        Assert.Equal(-404, response.Status.Code);
    }

    public override async Task GetTest()
    {
        var requestMake = new BucketMakeRequest();
        requestMake.Name = "test-get";
        requestMake.Capacity = 10240000;
        var responseMake = await fixture_.getServiceBucket().Make(requestMake, fixture_.context);
        Assert.Equal(0, responseMake.Status.Code);

        var request = new BucketGetRequest();
        // 缺少UUID
        var response = await fixture_.getServiceBucket().Get(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);
        // 不存在
        request.Uuid = Guid.NewGuid().ToString();
        response = await fixture_.getServiceBucket().Get(request, fixture_.context);
        Assert.Equal(-404, response.Status.Code);
        // 已存在
        request.Uuid = responseMake.Uuid;
        response = await fixture_.getServiceBucket().Get(request, fixture_.context);
        Assert.Equal("test-get", response.Entity.Name);
    }

    public override async Task FindTest()
    {
        var requestMake = new BucketMakeRequest();
        requestMake.Name = "test-find";
        requestMake.Capacity = 10240000;
        var responseMake = await fixture_.getServiceBucket().Make(requestMake, fixture_.context);
        Assert.Equal(0, responseMake.Status.Code);

        // 缺少Name参数
        var request = new BucketFindRequest();
        var response = await fixture_.getServiceBucket().Find(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);

        // 不存在
        request.Name = "xxxxxx";
        response = await fixture_.getServiceBucket().Find(request, fixture_.context);
        Assert.Equal(-404, response.Status.Code);

        // 存在
        request.Name = "test-find";
        response = await fixture_.getServiceBucket().Find(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task SearchTest()
    {
        // 创建10个
        for (int i = 0; i < 10; i++)
        {
            var requestMake = new BucketMakeRequest();
            requestMake.Name = String.Format("Name-{0}", i + 1);
            requestMake.Remark = String.Format("Remark-{0}", i + 1);
            requestMake.Capacity = 10240000;
            var responseMake = await fixture_.getServiceBucket().Make(requestMake, fixture_.context);
            Assert.Equal(0, responseMake.Status.Code);
        }

        // 缺少Count参数
        var request = new BucketSearchRequest();
        var response = await fixture_.getServiceBucket().Search(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);

        // 空条件
        request.Offset = 0;
        request.Count = 100;
        response = await fixture_.getServiceBucket().Search(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        Assert.Empty(response.Entity);

        // Name
        request.Name = "me";
        request.Offset = 0;
        request.Count = 100;
        response = await fixture_.getServiceBucket().Search(request, fixture_.context);
        Assert.Equal(10, response.Entity.Count);
        Assert.Equal("Name-3", response.Entity[2].Name);

        // Name
        request.Name = "me";
        request.Offset = 3;
        request.Count = 2;
        response = await fixture_.getServiceBucket().Search(request, fixture_.context);
        Assert.Equal(2, response.Entity.Count);
        Assert.Equal("Name-4", response.Entity[0].Name);

        // Remark
        request.Remark = "mark";
        request.Offset = 0;
        request.Count = 100;
        response = await fixture_.getServiceBucket().Search(request, fixture_.context);
        Assert.Equal(10, response.Entity.Count);
        Assert.Equal("Remark-3", response.Entity[2].Remark);

        // Remark
        request.Remark = "mark";
        request.Offset = 3;
        request.Count = 2;
        response = await fixture_.getServiceBucket().Search(request, fixture_.context);
        Assert.Equal(2, response.Entity.Count);
        Assert.Equal("Remark-4", response.Entity[0].Remark);

        // Name and Remark
        request.Name = "me";
        request.Remark = "2";
        request.Offset = 0;
        request.Count = 100;
        response = await fixture_.getServiceBucket().Search(request, fixture_.context);
        Assert.Single(response.Entity);
        Assert.Equal("Name-2", response.Entity[0].Name);
    }

    public override async Task UpdateTest()
    {
        var requestMake = new BucketMakeRequest();
        requestMake.Name = "test-update";
        requestMake.Capacity = 10240000;
        var responseMake = await fixture_.getServiceBucket().Make(requestMake, fixture_.context);
        Assert.Equal(0, responseMake.Status.Code);

        // 缺少Uuid
        var request = new BucketUpdateRequest();
        var response = await fixture_.getServiceBucket().Update(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);

        // 不存在
        request = new BucketUpdateRequest();
        request.Uuid = Guid.NewGuid().ToString();
        response = await fixture_.getServiceBucket().Update(request, fixture_.context);
        Assert.Equal(-404, response.Status.Code);

        // 只修改Name
        request = new BucketUpdateRequest();
        request.Uuid = responseMake.Uuid;
        request.Name = "test-update-1";
        response = await fixture_.getServiceBucket().Update(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        var requestGet= new BucketGetRequest();
        requestGet.Uuid = responseMake.Uuid;
        var responseGet = await fixture_.getServiceBucket().Get(requestGet, fixture_.context);
        Assert.Equal(0, responseGet.Status.Code);
        Assert.Equal("test-update-1", responseGet.Entity.Name);
        Assert.Equal(10240000, (int)responseGet.Entity.TotalSize);
    }

    public override async Task ResetTokenTest()
    {
        var request = new BucketResetTokenRequest();
        var response = await fixture_.getServiceBucket().ResetToken(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task GenerateManifestTest()
    {
        var request = new BucketGenerateManifestRequest();
        var response = await fixture_.getServiceBucket().GenerateManifest(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task CleanTest()
    {
        var request = new BucketCleanRequest();
        var response = await fixture_.getServiceBucket().Clean(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

}
