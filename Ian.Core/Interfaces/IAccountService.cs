//HANDLES ALL REQUESTS THAT CREATE ACCOUNT OBJECTS AND QUERY ACCOUNT OBJECT FIELDS
namespace Ian.Core.Interfaces;

using System.Reflection.Metadata;
using Ian.Core.Requests;

public interface IAccountService
{
    Task<Guid?> GetAccountID(ulong UserId, string AccountName);

    Task<IAccount?> GetAccount(Guid AccountId); //

    Task<IAccount> CreateAccount(CreateAccountRequest request);

    Task<decimal> GetBalance(Guid AccountId);

    Task<List<ILedgerEntry>> GetAccountHistory(Guid accountId);

    Task<List<IAccount>> GetAllAccounts(ulong UserId);

    Task<bool> AccountExistsAsync(ulong discordId, string accountName);
}