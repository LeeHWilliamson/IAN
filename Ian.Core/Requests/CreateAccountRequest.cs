namespace Ian.Core.Requests;

public class CreateAccountRequest
{
    public Guid RequesterUserId { get; set; }
    public string AccountName { get; set; } = string.Empty;
}