using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Services;
using NetCord.Services.ApplicationCommands;

namespace Ian.Bot.BotCommands;

public class UserModule : ApplicationCommandModule<ApplicationCommandContext>
{
    private ICommandOrchestrator _commandOrchestrator;
    public UserModule(ICommandOrchestrator commandOrchestrator)
    {
        _commandOrchestrator = commandOrchestrator;
    }

    [SlashCommand("new", "Add a new user")]
    public async Task<string> AddUser()
    {
        // get the discord id
        ulong id = Context.User.Id;
        // add the user
        string res = await _commandOrchestrator.RouteRequest(new AddUserRequest(id));

        return res;
    }
}