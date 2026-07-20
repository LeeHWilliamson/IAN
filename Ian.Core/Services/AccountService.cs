using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Models;

namespace Ian.Core.Services;

public class AccountService : IAccountService
{
    public Task<bool> GetUser(ulong UserId)
    {
        throw new NotImplementedException();
    }

    public Task<Guid?> AccountExists(ulong UserId, string AccountName)
    {
        throw new NotImplementedException();
    }

    public Task<Account?> GetAccount(Guid AccountId)
    {
        throw new NotImplementedException();

    }
    public Task<Account> CreateAccount(CreateAccountRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetBalance(Guid AccountId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Account>?> GetAllAccounts(ulong UserId)
    {
        throw new NotImplementedException();
    }

    public Task<List<LedgerEntry>> GetTransactionHistory(Guid accountId)
    {
        throw new NotImplementedException();
    }
}