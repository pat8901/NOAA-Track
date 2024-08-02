using System.Reflection;
using NOAA_Track.Components;
using NOAA_Track.Models;

var builder = WebApplication.CreateBuilder(args);

// Setting up user secrets via configuration to keep sensitive information safe.
IConfigurationRoot config = new ConfigurationBuilder().AddUserSecrets(Assembly.GetEntryAssembly()!).Build();

// Adding Api key services. This is an alternative to IConfiguration dependency injection
// var noaaApiKey = builder.Configuration["NOAA:NCDCApiKey"];
// var MAP_KEY = builder.Configuration["NOAA:MapApiKey"];
// builder.Services.AddSingleton(new ApiKeyService(MAP_KEY));


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Adding HTTP Client for server-side rendering (SSR)
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// TODO: What does this do?
//app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
