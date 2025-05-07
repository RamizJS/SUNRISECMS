using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SUNRISECMS.Shared.Services;
using SUNRISECMS.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the SUNRISECMS.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
