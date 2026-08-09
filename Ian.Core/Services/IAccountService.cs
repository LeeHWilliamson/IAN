//HANDLES ALL REQUESTS THAT CREATE ACCOUNT OBJECTS AND QUERY ACCOUNT OBJECT FIELDS
using Ian.Core.Interfaces;

using Ian.Core.Requests;
using Ian.Primitives.Accounts;

namespace Ian.Core.Services;

public interface IAccountService
{
    public Task<Guid?> GetAccountID(ulong UserId, string AccountName);

    public Task<IAccountData?> GetAccount(Guid AccountId); //

    public Task<IAccount> CreateAccount(CreateAccountRequest request);

    public Task<decimal> GetBalance(Guid AccountId);

    public Task<List<ILedgerEntry>> GetAccountHistory(Guid accountId);

    public Task<List<IAccountData>> GetAllAccounts(ulong UserId);

    public Task<bool> AccountExistsAsync(ulong discordId, string accountName);
}