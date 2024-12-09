using BlazorDemo_WASM_ASPNETCORE_hosted.Client;
using BlazorDemo_WASM_ASPNETCORE_hosted.Client.Services.SuperHeroServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<SuperheroService, SuperheroService>();


await builder.Build().RunAsync();
