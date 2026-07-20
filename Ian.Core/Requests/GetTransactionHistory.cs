namespace Ian.Core.Requests;

public class GetTransactionHistory
{
    public string RequesterDiscordId { get; set; } = string.Empty;

    public Guid RequesterAccountId { get; set; }

}