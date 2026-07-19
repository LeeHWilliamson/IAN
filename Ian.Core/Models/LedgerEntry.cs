namespace Ian.Core.Models;

using Ian.Core.Enums; 
public class LedgerEntry
{
    public Guid Id {get; set; }

    public Guid SenderAccountId {get; set; }

    public Guid ReceiverAccountId { get; set; }

    public decimal Amount {get; set; }

    public TransactionType TransactionType {get; set;}

    public string Metadata { get; set;} = "";

    public DateTime CreatedAt { get; set; }
}