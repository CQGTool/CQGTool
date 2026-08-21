
using BlazorGlobalizationDashboard.Components;
using BlazorGlobalizationDashboard.Services;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add localization with Resources folder
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");





builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// Configure supported cultures
var supportedCultures = new[]
{
    new CultureInfo("en-US"),
    new CultureInfo("fr-FR"),
    new CultureInfo("es-ES"),
    new CultureInfo("de-DE"),
    new CultureInfo("ja-JP"),
    new CultureInfo("hi-IN"),
    new CultureInfo("ar-SA")
};

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en-US");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
});

// Add HttpContextAccessor
builder.Services.AddHttpContextAccessor();

// Register services
builder.Services.AddScoped<CultureService>();

var app = builder.Build();

// Configure pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Enable localization
app.UseRequestLocalization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();