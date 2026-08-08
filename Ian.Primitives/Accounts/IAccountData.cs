namespace Ian.Primitives.Accounts;
/// <summary>
/// If you're wondering why this is in primitives, it is becasue it defines the shape of a data structure.
/// </summary>
public interface IAccountData
{
    // tbh I don't know what this id is for
    // public Guid Id { get; }
    // The owner of this account
    public ulong DiscordId { get; }
    // What the owner named this account
    public string AccountName { get; }
    // The type of account
    public AccountType AccountType { get; }
    // How much the ian coin the current account has
    public decimal Balance { get; }

    // When the account was created...do we need this?
    // public DateTime CreatedAt { get; }

    // How much interest this account generates
    public decimal BaseInterestRate { get; }
}