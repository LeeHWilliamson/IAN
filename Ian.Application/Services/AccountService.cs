using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Primitives.Accounts;

namespace Ian.Core.Services;

public class AccountService : IAccountService
{
    public Task<Guid?> GetAccountIDAsync(ulong UserId, string AccountName)
    {
        throw new NotImplementedException();
    }

    public Task<IAccountData?> GetAccountAsync(Guid AccountId)
    {
        throw new NotImplementedException();

    }
    public Task<IAccount> CreateAccount(CreateAccountRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetBalanceAsync(Guid AccountId)
    {
        throw new NotImplementedException();
    }

    public Task<List<IAccountData>> GetAllAccountsAsync(ulong UserId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ILedgerEntry>> GetAccountHistoryAsync(Guid accountId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AccountExistsAsync(ulong discordId, string accountName)
    {
        throw new NotImplementedException();
    }

    public Task<IAccount> CreateAccountAsync(CreateAccountResult request)
    {
        throw new NotImplementedException();
    }
}