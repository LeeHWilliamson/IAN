using System.Data;
using Ian.Core.Interfaces;

namespace Ian.Data.Entities;

public class Portfolio : IPortfolio
{
    public Dictionary<string, IAccount> Accounts { get; private set; } = new();

    public void AddAccount(IAccount account)
    {
        if (!Accounts.TryAdd(account.AccountName, account))
        {
            throw new DataException($"Portfolio already contains account {account} with name {account.AccountName}");
        }
    }

    public void RemoveAccount(IAccount account)
    {
        if (!Accounts.Remove(account.AccountName))
        {
            throw new DataException($"Portfolio doesn't contain an account, {account}, with name {account.AccountName}");
        }
    }
}