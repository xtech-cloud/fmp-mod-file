
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using XTC.FMP.MOD.File.App.Service;

public abstract class TestFixtureBase : IDisposable
{
    public TestServerCallContext context { get; set; }

    public TestFixtureBase()
    {
        context = TestServerCallContext.Create();
    }

    public virtual void Dispose()
    {

        var options = new DatabaseOptions();
        var mongoClient = new MongoDB.Driver.MongoClient(options.Value.ConnectionString);
        mongoClient.DropDatabase(options.Value.DatabaseName);

    }


    protected BucketService? serviceBucket_ { get; set; }

    public BucketService getServiceBucket()
    {
        if(null == serviceBucket_)
        {
            newBucketService();
        }
        return serviceBucket_!;
    }

    /// <summary>
    /// 实例化服务
    /// </summary>
    /// <example>
    /// serviceBucket_ = new BucketService(new BucketDAO(new DatabaseOptions()));
    /// </example>
    protected abstract void newBucketService();

    protected HealthyService? serviceHealthy_ { get; set; }

    public HealthyService getServiceHealthy()
    {
        if(null == serviceHealthy_)
        {
            newHealthyService();
        }
        return serviceHealthy_!;
    }

    /// <summary>
    /// 实例化服务
    /// </summary>
    /// <example>
    /// serviceHealthy_ = new HealthyService(new HealthyDAO(new DatabaseOptions()));
    /// </example>
    protected abstract void newHealthyService();

    protected ObjectService? serviceObject_ { get; set; }

    public ObjectService getServiceObject()
    {
        if(null == serviceObject_)
        {
            newObjectService();
        }
        return serviceObject_!;
    }

    /// <summary>
    /// 实例化服务
    /// </summary>
    /// <example>
    /// serviceObject_ = new ObjectService(new ObjectDAO(new DatabaseOptions()));
    /// </example>
    protected abstract void newObjectService();

}

