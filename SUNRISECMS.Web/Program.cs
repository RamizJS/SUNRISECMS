using MudBlazor.Services;
using SUNRISECMS.Shared.Services;
using SUNRISECMS.Web.Components;
using SUNRISECMS.Web.Services;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
using SUNRISECMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Register Connection String 
builder.Services.AddDbContext<SunriseCMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Syncfusion Blazor Components
SyncfusionLicenseProvider.RegisterLicense("MzgzNTY0OEAzMjM5MmUzMDJlMzAzYjMyMzkzYmZ0WE1jaEtieHdrRWxGd21kQ2ZFQTR5ZzJFd3g5S3FsRnFpcGFZck1UT1k9");
builder.Services.AddSyncfusionBlazor();

// MudBlazor Components 
builder.Services.AddMudServices();

// Add device-specific services used by the SUNRISECMS.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(
        typeof(SUNRISECMS.Shared._Imports).Assembly,
        typeof(SUNRISECMS.Web.Client._Imports).Assembly);

app.Run();
