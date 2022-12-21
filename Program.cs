using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using System.Globalization;

using test_icudt_blazor_wasm;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("lb-LU");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("lb-LU");

await builder.Build().RunAsync();

