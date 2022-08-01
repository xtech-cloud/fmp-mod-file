
using XTC.FMP.MOD.File.LIB.Proto;

public class ObjectTest : ObjectUnitTestBase
{
    public ObjectTest(TestFixture _testFixture)
        : base(_testFixture)
    {
    }


    public override async Task PrepareTest()
    {
        var request = new ObjectPrepareRequest();
        var response = await fixture_.getServiceObject().Prepare(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task FlushTest()
    {
        var request = new ObjectFlushRequest();
        var response = await fixture_.getServiceObject().Flush(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task GetTest()
    {
        var request = new ObjectGetRequest();
        var response = await fixture_.getServiceObject().Get(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task FindTest()
    {
        var request = new ObjectFindRequest();
        var response = await fixture_.getServiceObject().Find(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task RemoveTest()
    {
        var request = new ObjectRemoveRequest();
        var response = await fixture_.getServiceObject().Remove(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task ListTest()
    {
        var request = new ObjectListRequest();
        var response = await fixture_.getServiceObject().List(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task SearchTest()
    {
        var request = new ObjectSearchRequest();
        var response = await fixture_.getServiceObject().Search(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task PublishTest()
    {
        var request = new ObjectPublishRequest();
        var response = await fixture_.getServiceObject().Publish(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task PreviewTest()
    {
        var request = new ObjectPreviewRequest();
        var response = await fixture_.getServiceObject().Preview(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task RetractTest()
    {
        var request = new ObjectRetractRequest();
        var response = await fixture_.getServiceObject().Retract(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task ConvertFromBase64Test()
    {
        var request = new ObjectConvertFromBase64Request();
        var response = await fixture_.getServiceObject().ConvertFromBase64(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task ConvertFromUrlTest()
    {
        var request = new ObjectConvertFromUrlRequest();
        var response = await fixture_.getServiceObject().ConvertFromUrl(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

}
