using Ian.Core.Interfaces;
using Ian.Primitives.Accounts;

namespace Ian.Core.Requests;

public struct CreateAccountRequest : IRequest
{
    public ulong RequesterId { get; private set; }
    public string AccountName { get; private set; }
    public AccountType AccountType { get; private set; }

    public Type RequestType => typeof(CreateAccountRequest);

    public CreateAccountRequest(string accountName, ulong userId, AccountType accountType)
    {
        AccountName = accountName;
        RequesterId = userId;
        AccountType = accountType;
    }
}