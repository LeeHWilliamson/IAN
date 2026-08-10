//HANDLES ALL REQUESTS THAT CREATE ACCOUNT OBJECTS AND QUERY ACCOUNT OBJECT FIELDS
using Ian.Core.Interfaces;

using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Primitives.Accounts;

namespace Ian.Core.Services;

public interface IAccountService
{
    public Task<Guid?> GetAccountIDAsync(ulong UserId, string AccountName);

    public Task<IAccountData?> GetAccountAsync(Guid AccountId); //

    public Task<IAccount> CreateAccountAsync(CreateAccountResult request);

    public Task<decimal> GetBalanceAsync(Guid AccountId);

    public Task<List<ILedgerEntry>> GetAccountHistoryAsync(Guid accountId);

    public Task<List<IAccountData>> GetAllAccountsAsync(ulong UserId);

    public Task<bool> AccountExistsAsync(ulong discordId, string accountName);
}