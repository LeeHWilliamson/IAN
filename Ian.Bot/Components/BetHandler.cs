using NetCord.Rest;
using NetCord.Services.ComponentInteractions;

namespace Ian.Bot.Components;

public class BetHandler : ComponentInteractionModule<ButtonInteractionContext>
{
    [ComponentInteraction("bet_accept")]
    public async Task HandleAccept(string betId, string targetUserId, string arbitratorId)
    {

        if (Context.User.Id != ulong.Parse(targetUserId))
        {
            await RespondAsync(InteractionCallback.Message(new InteractionMessageProperties
            {
                Content = $"This bet isn't for you, {Context.User.GlobalName}",
                Flags = NetCord.MessageFlags.Ephemeral
            }));
            return;
        }
        await RespondAsync(InteractionCallback.Message(new InteractionMessageProperties
        {
            Content = $"{Context.User.GlobalName} accepted the bet!",
            Flags = NetCord.MessageFlags.Crossposted
        }));


    }

    [ComponentInteraction("bet_decline")]
    public async Task HandleDecline(string betId, string targetUserId, string arbitratorId)
    {

        if (Context.User.Id != ulong.Parse(targetUserId))
        {
            await RespondAsync(InteractionCallback.Message(new InteractionMessageProperties
            {
                Content = $"This bet isn't for you, {Context.User.GlobalName}",
                Flags = NetCord.MessageFlags.Ephemeral
            }));
            return;
        }
        await RespondAsync(InteractionCallback.Message(new InteractionMessageProperties
        {
            Content = $"{Context.User.GlobalName} declined the bet!",
            Flags = NetCord.MessageFlags.Crossposted
        }));
        return;
    }
}