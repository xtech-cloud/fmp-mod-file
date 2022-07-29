using Moq;
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.App.Service;

public class BucketTest : BucketUnitTestBase
{
    private Mock<BucketDAO> mockBucketDAO_ { get; set; }

    public BucketTest()
    {
        mockBucketDAO_ = new Mock<BucketDAO>();
        mockBucketDAO_.Setup(
            m => m.CreateAsync(It.IsAny<XTC.FMP.MOD.File.App.Service.BucketEntity>())
        ).Returns(Task.CompletedTask);
        mockBucketDAO_.Setup(
           m => m.ListAsync(It.IsAny<int>(), It.IsAny<int>())
        ).Returns(Task.FromResult(new List<XTC.FMP.MOD.File.App.Service.BucketEntity>()));
        mockBucketDAO_.Setup(
            m => m.RemoveAsync(It.IsAny<string>())
        ).Returns(Task.CompletedTask);
    }

    [Fact]
    public override async Task MakeTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketMakeRequest();
        var response = await service.Make(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task ListTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketListRequest();
        var response = await service.List(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task RemoveTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketRemoveRequest();
        var response = await service.Remove(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task GetTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketGetRequest();
        var response = await service.Get(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task FindTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketFindRequest();
        var response = await service.Find(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task SearchTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketSearchRequest();
        var response = await service.Search(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task UpdateTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketUpdateRequest();
        var response = await service.Update(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task ResetTokenTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketResetTokenRequest();
        var response = await service.ResetToken(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task GenerateManifestTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketGenerateManifestRequest();
        var response = await service.GenerateManifest(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public override async Task CleanTest()
    {
        var service = new BucketService(mockBucketDAO_.Object);
        var request = new BucketCleanRequest();
        var response = await service.Clean(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

}
