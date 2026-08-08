using Ian.Core.Interfaces;
using NetCord.Services.ApplicationCommands;

namespace Ian.Bot.BotCommands;

public class AccountModule : ApplicationCommandModule<ApplicationCommandContext>
{
    private readonly IAccountService _accountService;

    public AccountModule(IAccountService accountService)
    {
        Console.WriteLine($"Instantiating AccountModule");
        _accountService = accountService;
    }

    [SlashCommand("balance", "Check your account balance")]
    public async Task<string> GetBalance()
    {
        ulong id = Context.User.Id;
        return $"User {id} is broke";
    }

    [SlashCommand("accountbalance", "Prints the balance for a specific account")]
    public async Task<string> EchoTest(string message)
    {
        // cast the string to whatever we use to look up accounts

        // Get the user id for look up
        ulong id = Context.User.Id;

        // look up the balance


        // return the balance
        return $"{message} balance: poor";
    }
}