using System.Dynamic;

namespace Ian.Core.Requests;

public class AccountBalanceRequest
{
   public ulong SenderDiscordID { get; set; } //ID of discord user making request

   public Guid AccountId { get; set; } //Account ID being inquired about

   public decimal Balance { get; set; }
   
}