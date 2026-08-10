using Ian.Core.Interfaces;
using Ian.Primitives.Accounts;

namespace Ian.Core.Results;

public struct CreateAccountResult : IResult
{
    public Type ResultType => typeof(CreateAccountResult);

    public bool Approved { get; private set; }
    public ulong RequesterId { get; private set; }
    public string AccountName { get; private set; }
    public AccountType AccountType { get; private set; }

    public CreateAccountResult(
        bool approved,
        ulong requesterId,
        string accountName,
        AccountType accountType
    )
    {
        Approved = approved;
        RequesterId = requesterId;
        AccountName = accountName;
        AccountType = accountType;
    }
}