using Ian.Core.Interfaces;
using Ian.Core.Requests;

namespace Ian.Core.Services;

public class AccountService : IAccountService
{
    public Task<Guid?> GetAccountID(ulong UserId, string AccountName)
    {
        throw new NotImplementedException();
    }

    public Task<IAccount?> GetAccount(Guid AccountId)
    {
        throw new NotImplementedException();

    }
    public Task<IAccount> CreateAccount(CreateAccountRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetBalance(Guid AccountId)
    {
        throw new NotImplementedException();
    }

    public Task<List<IAccount>> GetAllAccounts(ulong UserId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ILedgerEntry>> GetAccountHistory(Guid accountId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AccountExistsAsync(ulong discordId, string accountName)
    {
        throw new NotImplementedException();
    }
}