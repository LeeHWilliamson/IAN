//HANDLES ALL REQUESTS THAT CREATE ACCOUNT OBJECTS AND QUERY ACCOUNT OBJECT FIELDS
using Ian.Core.Interfaces;

using System.Reflection.Metadata;
using Ian.Core.Requests;
using Ian.Primitives.Accounts;

namespace Ian.Core.Services;

public interface IAccountService
{
    Task<Guid?> GetAccountID(ulong UserId, string AccountName);

    Task<IAccountData?> GetAccount(Guid AccountId); //

    Task<IAccountData> CreateAccount(CreateAccountRequest request);

    Task<decimal> GetBalance(Guid AccountId);

    Task<List<ILedgerEntry>> GetAccountHistory(Guid accountId);

    Task<List<IAccountData>> GetAllAccounts(ulong UserId);

    Task<bool> AccountExistsAsync(ulong discordId, string accountName);
}