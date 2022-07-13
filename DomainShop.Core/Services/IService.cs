namespace DomainShop.Core.Services;

public class Address
{
    public string ZipCode { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}

public interface IService
{
    Task<Address?> GetAddressAsync(string zipCode);
}