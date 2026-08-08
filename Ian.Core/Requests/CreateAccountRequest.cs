using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct CreateAccountRequest : IRequest
{
    public Guid RequesterUserId { get; private set; }
    public string AccountName { get; private set; }

    public Type RequestType => typeof(CreateAccountRequest);

    public CreateAccountRequest(string accountName)
    {
        AccountName = accountName;
        RequesterUserId = new();
    }
}