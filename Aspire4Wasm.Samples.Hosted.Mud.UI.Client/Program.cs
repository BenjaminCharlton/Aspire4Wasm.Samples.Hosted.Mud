using Aspire4Wasm.Samples.Hosted.Mud.UI;
using Aspire4Wasm.Samples.Hosted.Mud.UI.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.AddServiceDefaults();
builder.Services.AddHttpClient<IWeatherClient, WeatherApiClient>(client => client.BaseAddress = new Uri("https+http://api"));

await builder.Build().RunAsync();
