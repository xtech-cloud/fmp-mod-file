
using Moq;
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.App.Service;

public class HealthyTest : HealthyUnitTestBase
{
    private TestServerCallContext context_ { get; set; }
    private HealthyService service_ { get; set; }
    //private Mock<YourMockDAO> mockYourDAO_ { get; set; }
    public HealthyTest()
    {
        context_ = TestServerCallContext.Create();
        //mockYourDAO_ = YourMockDAO.NewMock();
        //service_ = new HealthyService(mockYoutDAO_.Object);
        service_ = new HealthyService();
    }

    [Fact]
    public override async Task EchoTest()
    {
        var request = new HealthyEchoRequest();
        var response = await service_.Echo(request, context_);
        Assert.Equal(0, response.Status.Code);
    }

}
