using DomainShop.Core.Services;

namespace DomainShop.Core.UseCases.GetAddress;

public class Handler
{
    private readonly IService _service;

    public Handler(IService service)
        => _service = service;

    public async Task<Response> HandleAsync(Request request)
    {
        var address = await _service.GetAddressAsync(request.ZipCode);

        return new Response
        {
            ZipCode = address?.ZipCode ?? string.Empty,
            Street = address?.Street ?? string.Empty,
            District = address?.District ?? string.Empty,
            State = address?.State ?? string.Empty,
            Country = address?.Country ?? string.Empty
        };
    }
}