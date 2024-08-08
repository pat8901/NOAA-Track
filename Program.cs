using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NOAA_Track.Components;
using NOAA_Track.Database;
using NOAA_Track.Models;
using NOAA_Track.Services;

var builder = WebApplication.CreateBuilder(args);

// Setting up user secrets via configuration to keep sensitive information safe.
IConfigurationRoot config = new ConfigurationBuilder()
.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
.AddUserSecrets(Assembly.GetEntryAssembly()!)
.Build();

// Adding Api key services. This is an alternative to IConfiguration dependency injection
// var noaaApiKey = builder.Configuration["NOAA:NCDCApiKey"];
// var MAP_KEY = builder.Configuration["NOAA:MapApiKey"];
// builder.Services.AddSingleton(new ApiKeyService(MAP_KEY));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Adding HTTP Client for server-side rendering (SSR)
builder.Services.AddHttpClient();

// Adding Satellite SQL Server DB service to application
var connection_string = builder.Configuration["NoaaDatabase:ConnectString"];
builder.Services.AddDbContextFactory<SatelliteContext>(options =>
    options.UseSqlServer(connection_string));

// Adding Weather SQL Server DB service to application
var weather_connection_string = builder.Configuration["WeatherDataBase:ConnectString"];
builder.Services.AddDbContextFactory<WeatherContext>(options =>
    options.UseSqlServer(weather_connection_string));

// Adding Users SQL Server DB service for user authentication
var users_connection_string = builder.Configuration["UsersDataBase:ConnectString"];
builder.Services.AddDbContext<UsersContext>(options => options.UseSqlServer(users_connection_string));
builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<IdentityUser>().AddEntityFrameworkStores<UsersContext>();

// Adding database middleware service. Handles communication between database and backend.
//builder.Services.AddSingleton<SatelliteService>();
// If I wanted more than one instance
builder.Services.AddTransient<SatelliteService>();
builder.Services.AddTransient<WeatherService>();

// Build Web Application
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapIdentityApi<IdentityUser>();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.MapGet("/hi", () => "Hello!");

app.Run();
