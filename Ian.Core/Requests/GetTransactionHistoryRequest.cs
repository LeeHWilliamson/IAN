using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct GetTransactionHistoryRequest : IRequest
{
    public string RequesterDiscordId { get; private set; } = string.Empty;

    public Guid RequesterAccountId { get; private set; }

    public Type RequestType => typeof(GetTransactionHistoryRequest);

    public GetTransactionHistoryRequest(Guid requesterAccountId)
    {
        RequesterAccountId = requesterAccountId;
    }
}