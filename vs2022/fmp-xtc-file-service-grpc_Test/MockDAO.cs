using Moq;
using Microsoft.Extensions.Options;
using XTC.FMP.MOD.File.App.Service;

public class BucketMockDAO : BucketDAO
{
    public BucketMockDAO(IOptions<DatabaseSettings> _settings) : base(_settings)
    {
    }

    public BucketMockDAO()
         : base(new DatabaseOptions())
    {

    }

    public static Mock<BucketMockDAO> NewMock()
    {
        var mockDAO = new Mock<BucketMockDAO>();
        mockDAO.Setup(
            m => m.CreateAsync(It.IsAny<BucketEntity>())
        ).Returns(Task.CompletedTask);

        mockDAO.Setup(
          m => m.GetAsync(It.IsAny<string>())
        ).Returns(Task.FromResult(new BucketEntity()));

        mockDAO.Setup(
           m => m.ListAsync(It.IsAny<int>(), It.IsAny<int>())
        ).Returns(Task.FromResult(new List<BucketEntity>()));

        mockDAO.Setup(
            m => m.RemoveAsync(It.IsAny<string>())
        ).Returns(Task.CompletedTask);
        return mockDAO;
    }

}
