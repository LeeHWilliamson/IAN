using Ian.Primitives.Transactions;

namespace Ian.Core.Interfaces;

public interface ILedgerEntry
{
    public Guid Id { get; }

    public Guid SenderAccountId { get; }

    public Guid ReceiverAccountId { get; }

    public decimal Amount { get; }

    public TransactionType TransactionType { get; }

    public string Metadata { get; }

    public DateTime CreatedAt { get; }
}