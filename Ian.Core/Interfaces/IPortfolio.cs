namespace Ian.Core.Interfaces;

public interface IPortfolio
{
    public Dictionary<string, IAccount> Accounts { get; }
    public void AddAccount(IAccount account);
    public void RemoveAccount(IAccount account);
}