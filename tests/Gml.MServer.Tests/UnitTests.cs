using Gml.MServer.Lib;

namespace Gml.MServer.Tests;

public class Tests
{
    private GmlServerManager _gmlServerManager;

    [SetUp]
    public void Setup()
    {

        _gmlServerManager = new GmlServerManager();

    }

    [Test]
    public async Task GetVersionsList()
    {
        Assert.That(await _gmlServerManager.GetVersionsAsync(), Is.Not.Empty);
    }

    [Test]
    public async Task GetServersList()
    {
        var servers = await _gmlServerManager.GetServersAsync();
        
        Assert.That(servers, Is.Not.Empty);
    }
}