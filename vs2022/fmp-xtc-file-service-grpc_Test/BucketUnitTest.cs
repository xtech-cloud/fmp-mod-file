
using Moq;
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.App.Service;

public class BucketTest : BucketUnitTestBase
{
    private TestServerCallContext context_ { get; set; }
    private BucketService service_ { get; set; }
    private Mock<BucketMockDAO> mockBucketDAO_ { get; set; }
    public BucketTest()
    {
        context_ = TestServerCallContext.Create();
        mockBucketDAO_ = BucketMockDAO.NewMock();
        service_ = new BucketService(mockBucketDAO_.Object);
        //service_ = new BucketService();
    }

    [Fact]
    public override async Task MakeTest()
    {
        var request = new BucketMakeRequest();
        var response = await service_.Make(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task ListTest()
    {
        var request = new BucketListRequest();
        var response = await service_.List(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task RemoveTest()
    {
        var request = new BucketRemoveRequest();
        var response = await service_.Remove(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task GetTest()
    {
        var request = new BucketGetRequest();
        var response = await service_.Get(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task FindTest()
    {
        var request = new BucketFindRequest();
        var response = await service_.Find(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task SearchTest()
    {
        var request = new BucketSearchRequest();
        var response = await service_.Search(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task UpdateTest()
    {
        var request = new BucketUpdateRequest();
        var response = await service_.Update(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task ResetTokenTest()
    {
        var request = new BucketResetTokenRequest();
        var response = await service_.ResetToken(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task GenerateManifestTest()
    {
        var request = new BucketGenerateManifestRequest();
        var response = await service_.GenerateManifest(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task CleanTest()
    {
        var request = new BucketCleanRequest();
        var response = await service_.Clean(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

}
