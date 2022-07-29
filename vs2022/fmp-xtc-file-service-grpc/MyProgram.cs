
using XTC.FMP.MOD.File.App.Service;

public static class MyProgram
{
    public static void PreBuild(WebApplicationBuilder? _builder)
    {
        _builder?.Services.AddSingleton<BucketDAO>();
    }

    public static void PreRun(WebApplication? _app)
    {
    }
}
