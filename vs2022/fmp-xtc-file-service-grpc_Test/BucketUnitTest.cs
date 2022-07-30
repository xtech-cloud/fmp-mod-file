using XTC.FMP.MOD.File.LIB.Proto;

public class BucketTest : BucketUnitTestBase
{
    public BucketTest(TestFixture _testFixture)
        :base(_testFixture)
    {

    }

    public override async Task MakeTest()
    {
        var request = new BucketMakeRequest();
        // 缺少Name
        var response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(1, response.Status.Code);
        // 缺少Capacity
        request.Name = "Test";
        response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(1, response.Status.Code);
        // 成功
        request.Capacity = 102400000;
        response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
        // 已存在
        response = await fixture_.getServiceBucket().Make(request, fixture_.context);
        Assert.Equal(2, response.Status.Code);
    }

    public override async Task ListTest()
    {
        var request = new BucketListRequest();
        var response = await fixture_.getServiceBucket().List(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override Task RemoveTest()
    {
        throw new NotImplementedException();
    }

    public override Task GetTest()
    {
        throw new NotImplementedException();
    }

    public override Task FindTest()
    {
        throw new NotImplementedException();
    }

    public override Task SearchTest()
    {
        throw new NotImplementedException();
    }

    public override Task UpdateTest()
    {
        throw new NotImplementedException();
    }

    public override Task ResetTokenTest()
    {
        throw new NotImplementedException();
    }

    public override Task GenerateManifestTest()
    {
        throw new NotImplementedException();
    }

    public override Task CleanTest()
    {
        throw new NotImplementedException();
    }
}
