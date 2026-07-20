namespace Ian.Core.Interfaces;

using System.Reflection.Metadata;
using Ian.Core.Models;
using Ian.Core.Requests;

public interface IAccountService
{

    Task<bool> GetUser(ulong DiscordId); //see if DiscordId exists in users table, if so, return True

    Task<Guid?> AccountExists(ulong UserId, string AccountName);

    Task<Account?> GetAccount(Guid AccountId); //

    Task<Account> CreateAccount(CreateAccountRequest request);

    Task <decimal> GetBalance(Guid AccountId);

    Task<List<LedgerEntry>> GetTransactionHistory(Guid accountId);

    Task<List<Account>?> GetAllAccounts(ulong UserId);
}