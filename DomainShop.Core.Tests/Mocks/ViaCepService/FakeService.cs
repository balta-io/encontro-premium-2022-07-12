using DomainShop.Core.Services;

namespace DomainShop.Core.Tests.Mocks.ViaCepService;

public class FakeService : IService
{
    public async Task<Address?> GetAddressAsync(string zipCode)
    {
        await Task.Delay(1);
        return new Address
        {
            ZipCode = "01001-000",
            Street = "Praça da Sé",
            District = "Sé",
            State = "SP",
            Country = "BR"
        };
    }
}