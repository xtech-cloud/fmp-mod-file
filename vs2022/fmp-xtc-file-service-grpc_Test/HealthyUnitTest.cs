
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.App.Service;

public class HealthyTest : HealthyUnitTestBase
{

    [Fact]
    public override async Task EchoTest()
    {
        // var service = new HealthyService(DAOManager<YourDAO>.Value);
        var service = new HealthyService();
        var request = new HealthyEchoRequest();
        var response = await service.Echo(request, TestServerCallContext.Create());
        Assert.Equal(0, response.Status.Code);
    }

}
