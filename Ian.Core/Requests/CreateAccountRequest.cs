using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct CreateAccountRequest : IRequest
{
    public ulong RequesterId { get; private set; }
    public string AccountName { get; private set; }

    public Type RequestType => typeof(CreateAccountRequest);

    public CreateAccountRequest(string accountName, ulong userId)
    {
        AccountName = accountName;
        RequesterId = userId;
    }
}