using Ian.Application.RequestHandling;
using Ian.Application.ResultHandling;
using Ian.Application.Services;
using Ian.Core.Infrastructure;
using Ian.Core.Interfaces;
using Ian.Core.Services;
using Infrastructure.Application.EventBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NetCord;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;
using NetCord.Hosting.Services.ComponentInteractions;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using NetCord.Services.ComponentInteractions;
using Serilog;

namespace Ian.Bot;

public class BootStrapper
{
    public static async Task Main(string[] args)
    {

        // Setup a logger
        using var log = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        Log.Logger = log;
        Log.Information($"The global logger has been configured successfully.");

        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        // Register services
        builder.Services
            .AddDiscordGateway()
            .AddApplicationCommands()
            .AddComponentInteractions<ButtonInteraction, ButtonInteractionContext>()
            .AddSingleton<IAccountService, InMemoryAccountService>()
            .AddSingleton<IUserService, InMemoryUserService>()
            .AddScoped<IBetService, BetService>()
            .AddScoped<IRequestHandler, RequestHandler>()
            .AddScoped<IResultHandler, ResultHandler>()
            .AddScoped<ICommandOrchestrator, CommandOrchestrator>()
            .AddSingleton<IEventBus, EventBus>();

        // Gets the secrets for the bot
        builder.Configuration.AddUserSecrets<BootStrapper>();

        // Build everything
        IHost host = builder.Build();

        // Add commands from a module
        host.AddModules(typeof(BootStrapper).Assembly);


        await host.RunAsync();
    }
}

