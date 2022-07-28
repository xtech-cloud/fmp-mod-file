
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.App.Service;

public class ObjectBaseTest
{

    [Fact]
    public virtual async Task PrepareTest()
    {
        var service = new ObjectService();
        var request = new ObjectPrepareRequest();
        var response = await service.Prepare(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task FlushTest()
    {
        var service = new ObjectService();
        var request = new ObjectFlushRequest();
        var response = await service.Flush(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task GetTest()
    {
        var service = new ObjectService();
        var request = new ObjectGetRequest();
        var response = await service.Get(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task FindTest()
    {
        var service = new ObjectService();
        var request = new ObjectFindRequest();
        var response = await service.Find(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task RemoveTest()
    {
        var service = new ObjectService();
        var request = new ObjectRemoveRequest();
        var response = await service.Remove(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task ListTest()
    {
        var service = new ObjectService();
        var request = new ObjectListRequest();
        var response = await service.List(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task SearchTest()
    {
        var service = new ObjectService();
        var request = new ObjectSearchRequest();
        var response = await service.Search(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task PublishTest()
    {
        var service = new ObjectService();
        var request = new ObjectPublishRequest();
        var response = await service.Publish(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task PreviewTest()
    {
        var service = new ObjectService();
        var request = new ObjectPreviewRequest();
        var response = await service.Preview(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task RetractTest()
    {
        var service = new ObjectService();
        var request = new ObjectRetractRequest();
        var response = await service.Retract(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task ConvertFromBase64Test()
    {
        var service = new ObjectService();
        var request = new ObjectConvertFromBase64Request();
        var response = await service.ConvertFromBase64(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

    [Fact]
    public virtual async Task ConvertFromUrlTest()
    {
        var service = new ObjectService();
        var request = new ObjectConvertFromUrlRequest();
        var response = await service.ConvertFromUrl(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

}
