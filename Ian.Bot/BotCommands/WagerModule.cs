using Ian.Bot.Components;
using Ian.Core.Interfaces;
using Ian.Core.Services;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using NetCord.Services.ComponentInteractions;

namespace Ian.Bot.BotCommands;

public class WagerModule : ApplicationCommandModule<ApplicationCommandContext>
{
    private readonly IAccountService _accountService;
    private readonly ICommandOrchestrator _commandOrchestrator;
    private readonly IBetService _betService;

    public WagerModule(IAccountService accountService, ICommandOrchestrator commandOrchestrator, IBetService betService)
    {
        Console.WriteLine($"Instantiating WagerModule");
        _accountService = accountService;
        _commandOrchestrator = commandOrchestrator;
        _betService = betService;
    }

    [SlashCommand("bet", "Place a bet!")]
    public async Task PlaceBet(
                                decimal ianCoins,
                                string terms,
                                NetCord.User otherUser,
                                NetCord.User arbitrator)
    {
        if (ianCoins == 1)
        {

            await RespondAsync(InteractionCallback.Message(new InteractionMessageProperties
            {
                Content = $"Bets must be at least 1 Ian Coin",
                Flags = NetCord.MessageFlags.Ephemeral,
            }));
            return;
        }

        Guid betId = new();

        // Make the buttons
        var acceptButton = new ButtonProperties($"bet_accept:{betId}:{otherUser.Id}:{arbitrator.Id}", "Accept", NetCord.ButtonStyle.Success);

        var declineButton = new ButtonProperties($"bet_decline:{betId}:{otherUser.Id}:{arbitrator.Id}", "Decline", NetCord.ButtonStyle.Danger);

        await RespondAsync(InteractionCallback.Message(new InteractionMessageProperties
        {
            Content = $"{Context.User} bets {ianCoins} IanCoins that: {terms}; against {otherUser}",
            Components = [new ActionRowProperties([acceptButton, declineButton])],
            Flags = NetCord.MessageFlags.Ephemeral
        }));
        return;
    }

    [SlashCommand("pending", "List bets awaiting your judgement")]
    public async Task ListPendingBets(NetCord.User arbiter)
    {
        // ping the db for the bets waiting on some action
    }
}