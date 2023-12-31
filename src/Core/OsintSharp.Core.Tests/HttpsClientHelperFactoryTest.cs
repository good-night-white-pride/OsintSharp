using OsintSharp.Core.Factories;

namespace OsintSharp.Core.Tests;

public class HttpsClientHelperFactoryTest
{
    #region NotNull
    [Fact]
    public void FactoryClientNotNull()
    {
        var factory = new HttpsClientHelperFactory();
        var client = factory.Create();

        Assert.NotNull(client);
    }

    [Fact]
    public void FactoryClientClientNotNull()
    {
        var factory = new HttpsClientHelperFactory();
        var client = factory.Create();

        Assert.NotNull(client.Client);
    }

    [Fact]
    public void FactoryClientHttpMessageNotNull()
    {
        var factory = new HttpsClientHelperFactory();
        var client = factory.Create();
        var url = "https://www.google.com/";

        Assert.NotNull(client.GetAsync(url).Result);
    }
    #endregion
}