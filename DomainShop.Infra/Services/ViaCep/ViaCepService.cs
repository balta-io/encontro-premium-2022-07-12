using DomainShop.Core.Services;
using DomainShop.Infra.Services.ViaCep.Models;
using RestSharp;

namespace DomainShop.Infra.Services.ViaCep;

public class ViaCepService : IService
{
    public async Task<Address?> GetAddressAsync(string zipCode)
    {
        var client = new RestClient($"https://viacep.com.br/ws/{zipCode}/json/");
        var request = new RestRequest();
        var response = await client.GetAsync<Response>(request, new CancellationToken());
        return new Address
        {
            ZipCode = response?.ZipCode ?? string.Empty,
            Country = "BR",
            District = response?.Bairro ?? string.Empty,
            State = response?.Uf ?? string.Empty,
            Street = response?.Logradouro ?? string.Empty
        };
    }
}