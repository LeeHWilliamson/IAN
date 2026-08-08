namespace Ian.Core.Interfaces;

public interface IPortfolio
{
    public List<IAccount> Accounts { get; }

    public void OpenAccount(IAccount account);
    public void CloseAccount(IAccount account);
}