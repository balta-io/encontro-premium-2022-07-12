using DomainShop.Core.Services;
using DomainShop.Core.UseCases.GetAddress;
using DomainShop.Infra.Services.ViaCep;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IService, ViaCepService>();
builder.Services.AddTransient<Handler>();

var app = builder.Build();

app.MapGet("/{zipCode}", async (
    string zipCode,
    Handler handler) =>
{
    var request = new Request { ZipCode = zipCode };
    var response = await handler.HandleAsync(request);
    return Results.Ok(response);
});

app.Run();