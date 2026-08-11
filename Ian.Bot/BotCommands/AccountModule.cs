using System.Diagnostics;
using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Core.Services;
using Ian.Primitives.Accounts;
using NetCord.Services.ApplicationCommands;

namespace Ian.Bot.BotCommands;

public class AccountModule : ApplicationCommandModule<ApplicationCommandContext>
{
    private readonly ICommandOrchestrator _commandOrchestrator;

    public AccountModule(ICommandOrchestrator commandOrchestrator)
    {
        Console.WriteLine($"Instantiating AccountModule");
        _commandOrchestrator = commandOrchestrator;
    }
    [SlashCommand("portfolio", "Prints the details of your portfolio")]
    public async Task<string> PrintPortfolio()
    {
        // get the user id
        ulong id = Context.User.Id;
        // submit a portfolio print request
        string res = await _commandOrchestrator.RouteRequest(new ViewPortfolioRequest(id));
        return res;
    }

    [SlashCommand("balance", "Prints the balance for a specific account")]
    public async Task<string> CheckAccountBalance(string accountName)
    {
        // cast the string to whatever we use to look up accounts

        // Get the user id for look up
        string id = Context.User.GlobalName;

        // look up the balance


        // return the balance
        return $"{id} balance: poor";
    }

    [SlashCommand("openaccount", "Opens a new account with the given name")]
    public async Task<string> OpenAccount(string accountName, AccountType accountType)
    {
        // Request opening a new account for this user
        string feedback = await _commandOrchestrator.RouteRequest(new CreateAccountRequest(accountName, Context.User.Id, accountType));

        return feedback;
    }


}