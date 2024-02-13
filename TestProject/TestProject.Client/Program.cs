using BlazorCrud.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Security.Principal;
using TestProject.Services;
using TestProject.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});
builder.Services.AddScoped<IDriverServices, ClientDriverService>();
builder.Services.AddScoped<IDriverServices, ClientDriverService>();
builder.Services.AddScoped<IDriverServices, ClientDriverService>();

await builder.Build().RunAsync();
