using Ian.Core.Interfaces;
using Ian.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using NetCord;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;
using NetCord.Rest;

namespace Ian.Bot;

public class BootStrapper
{
    public static async Task Main(string[] args)
    {

        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        // Register services
        builder.Services
            .AddDiscordGateway()
            .AddApplicationCommands()
            .AddScoped<IAccountService, AccountService>();

        // Gets the secrets for the bot
        builder.Configuration.AddUserSecrets<BootStrapper>();

        // Build everything
        IHost host = builder.Build();

        // Add commands from a module
        host.AddModules(typeof(BootStrapper).Assembly);


        await host.RunAsync();
    }
}

