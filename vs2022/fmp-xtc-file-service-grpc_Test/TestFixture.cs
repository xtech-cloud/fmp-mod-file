
using XTC.FMP.MOD.File.App.Service;

/// <summary>
/// 测试上下文，用于共享测试资源
/// </summary>
public class TestFixture : TestFixtureBase
{
    public TestFixture()
        : base()
    {
    }

    public override void Dispose()
    {
        base.Dispose();
    }


    protected override void newBucketService()
    {
        serviceBucket_ = new BucketService(new BucketDAO(new DatabaseOptions()));
    }

    protected override void newHealthyService()
    {
        serviceHealthy_ = new HealthyService();
    }

    protected override void newObjectService()
    {
        throw new NotImplementedException();
        //serviceObject_ = new ObjectService(new ObjectDAO(new DatabaseOptions()));
    }

}
