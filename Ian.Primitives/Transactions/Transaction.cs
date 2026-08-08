namespace Ian.Primitives.Transactions;

public struct Transaction
{
    public readonly Guid Id;
    public readonly Guid SenderAccountId;
    public readonly Guid ReceiverAccountId;
    public readonly decimal Amount;
    public readonly TransactionType TransactionType;
    public readonly string Metadata;
    public readonly DateTime CreatedAt;

    public Transaction(
                        Guid senderAccountId,
                        Guid receiverAccountId,
                        decimal amount,
                        TransactionType transactionType)
    {
        Id = new();
        SenderAccountId = senderAccountId;
        ReceiverAccountId = receiverAccountId;
        Amount = amount;
        TransactionType = transactionType;

        Metadata = "";
        CreatedAt = DateTime.Now;
    }

    public Transaction(
                        Guid id,
                        Guid senderAccountId,
                        Guid receiverAccountId,
                        decimal amount,
                        TransactionType transactionType)
    {
        Id = id;
        SenderAccountId = senderAccountId;
        ReceiverAccountId = receiverAccountId;
        Amount = amount;
        TransactionType = transactionType;

        Metadata = "";
        CreatedAt = DateTime.Now;
    }

    public Transaction(
                    Guid id,
                    Guid senderAccountId,
                    Guid receiverAccountId,
                    decimal amount,
                    TransactionType transactionType,
                    string metaData)
    {
        Id = id;
        SenderAccountId = senderAccountId;
        ReceiverAccountId = receiverAccountId;
        Amount = amount;
        TransactionType = transactionType;
        Metadata = metaData;
        CreatedAt = DateTime.Now;
    }
}