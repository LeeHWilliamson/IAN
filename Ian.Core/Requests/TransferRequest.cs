using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct TransferRequest : IRequest
{
    public ulong SenderDiscordId { get; private set; }

    public ulong ReceiverDiscordId { get; private set; }

    public Guid SenderAccountId { get; private set; }

    public Guid ReceiverAccountId { get; private set; }
    public decimal Amount { get; private set; }
    public string SenderAccountName { get; private set; }
    public string ReceiverAccountName { get; private set; }
    public string Reason { get; private set; }
    public Type RequestType => typeof(TransferRequest);

    public TransferRequest(ulong senderDiscord,
                            ulong receiverDiscord,
                            Guid senderAccount,
                            Guid recevierAccount,
                            decimal amount,
                            string senderName = "",
                            string receiverName = "",
                            string reason = "")
    {
        SenderDiscordId = senderDiscord;
        ReceiverDiscordId = receiverDiscord;
        SenderAccountId = senderAccount;
        ReceiverAccountId = recevierAccount;
        Amount = amount;
        SenderAccountName = senderName;
        ReceiverAccountName = receiverName;
        Reason = reason;
    }
}