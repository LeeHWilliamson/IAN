namespace Ian.Core.Requests;

public class TransferRequest
{
    public ulong SenderDiscordId { get; set; }

    public ulong ReceiverDiscordId { get; set; }
    
    public Guid SenderAccountId { get; set; }

    public Guid ReceiverAccountId { get; set; }

    public string SenderAccountName { get; set; } = "";

    public string ReceiverAccountName = "";

    public decimal Amount { get; set; }

    public string Reason { get; set;} = "";
}