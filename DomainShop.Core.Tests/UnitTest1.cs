using DomainShop.Core.Tests.Mocks.ViaCepService;
using DomainShop.Core.UseCases.GetAddress;

namespace DomainShop.Core.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public async Task TestMethod1()
    {
        var service = new FakeService();
        var handler = new Handler(service);
        var request = new Request
        {
            ZipCode = "12345678"
        };
        var result = await handler.HandleAsync(request);
        Assert.IsNotNull(result);
    }
}