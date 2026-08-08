using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using NetCord;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;
using NetCord.Rest;

var builder = Host.CreateApplicationBuilder(args);

// Register services
builder.Services
    .AddDiscordGateway()
    .AddApplicationCommands();

// Gets the secrets for the bot
builder.Configuration.AddUserSecrets<Program>();

// Build everything
var host = builder.Build();

// // Add commands using minimal APIs
// host.AddSlashCommand("ping", "Ping!", () => "Pong!");
// host.AddSlashCommand("ball", "Ball is life", () => "WHERE");
// host.AddUserCommand("Username", (NetCord.User user) => user.Username);
// host.AddMessageCommand("Length", (RestMessage message) => message.Content.Length.ToString());

// Add commands from a module
host.AddModules(typeof(Program).Assembly);

await host.RunAsync();
