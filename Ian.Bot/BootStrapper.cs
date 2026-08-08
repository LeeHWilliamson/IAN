using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using NetCord.Hosting.Gateway;

var builder = Host.CreateApplicationBuilder(args);

// Register services
builder.Services
    .AddDiscordGateway();

builder.Configuration.AddUserSecrets<Program>();

// Build everything
var host = builder.Build();

await host.RunAsync();
