using Ian.Core.Interfaces;
using Ian.Primitives.Transactions;

namespace Ian.Application.Models;

/// <summary>
/// A class that records specific transactions
/// </summary>
public struct LedgerEntry : ILedgerEntry
{
    // Transaction id
    public Guid Id { get; private set; }
    // Where the money is coming from
    public Guid SenderAccountId { get; private set; }
    // Where the money is going to
    public Guid ReceiverAccountId { get; private set; }
    // The amount of money being moved
    public decimal Amount { get; private set; }
    // How the transaction is calculated
    public TransactionType TransactionType { get; private set; }
    // Notes on circumstance
    public string Metadata { get; private set; }
    // When this transaction occured
    public DateTime CreatedAt { get; private set; }

    public LedgerEntry(Transaction transaction)
    {
        Id = transaction.Id;
        SenderAccountId = transaction.SenderAccountId;
        ReceiverAccountId = transaction.ReceiverAccountId;
        Amount = transaction.Amount;
        TransactionType = transaction.TransactionType;

        Metadata = transaction.Metadata;
        CreatedAt = transaction.CreatedAt;
    }
}