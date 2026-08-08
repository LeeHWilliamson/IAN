using System.Dynamic;
using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct AccountBalanceRequest : IRequest
{
   public ulong SenderDiscordID { get; set; } //ID of discord user making request

   public Guid AccountId { get; set; } //Account ID being inquired about

   // public decimal Balance { get; set; } // why is this here?

   public Type RequestType => typeof(AccountBalanceRequest);

   public AccountBalanceRequest(ulong senderDiscord, Guid accountId)
   {
      SenderDiscordID = senderDiscord;
      AccountId = accountId;
   }
}