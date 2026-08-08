using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Ian.Bot.BotCommands;

public class TestModule : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("ping", "Ping!")]
    public static string Ping() => "Pong!";

    [UserCommand("ID")]
    public static string Id(NetCord.User user) => user.Id.ToString();

    [MessageCommand("Timestamp")]
    public static string Timestamp(RestMessage message) => message.CreatedAt.ToString();
}