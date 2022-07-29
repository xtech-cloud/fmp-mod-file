
using Moq;
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.App.Service;

public class ObjectTest : ObjectUnitTestBase
{
    private TestServerCallContext context_ { get; set; }
    private ObjectService service_ { get; set; }
    //private Mock<YourMockDAO> mockYourDAO_ { get; set; }
    public ObjectTest()
    {
        context_ = TestServerCallContext.Create();
        //mockYourDAO_ = YourMockDAO.NewMock();
        //service_ = new ObjectService(mockYoutDAO_.Object);
        service_ = new ObjectService();
    }

    [Fact]
    public override async Task PrepareTest()
    {
        var request = new ObjectPrepareRequest();
        var response = await service_.Prepare(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task FlushTest()
    {
        var request = new ObjectFlushRequest();
        var response = await service_.Flush(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task GetTest()
    {
        var request = new ObjectGetRequest();
        var response = await service_.Get(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task FindTest()
    {
        var request = new ObjectFindRequest();
        var response = await service_.Find(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task RemoveTest()
    {
        var request = new ObjectRemoveRequest();
        var response = await service_.Remove(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task ListTest()
    {
        var request = new ObjectListRequest();
        var response = await service_.List(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task SearchTest()
    {
        var request = new ObjectSearchRequest();
        var response = await service_.Search(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task PublishTest()
    {
        var request = new ObjectPublishRequest();
        var response = await service_.Publish(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task PreviewTest()
    {
        var request = new ObjectPreviewRequest();
        var response = await service_.Preview(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task RetractTest()
    {
        var request = new ObjectRetractRequest();
        var response = await service_.Retract(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task ConvertFromBase64Test()
    {
        var request = new ObjectConvertFromBase64Request();
        var response = await service_.ConvertFromBase64(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task ConvertFromUrlTest()
    {
        var request = new ObjectConvertFromUrlRequest();
        var response = await service_.ConvertFromUrl(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

}
