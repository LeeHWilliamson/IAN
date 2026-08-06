//HANDLES ALL REQUESTS THAT CREATE ACCOUNT OBJECTS AND QUERY ACCOUNT OBJECT FIELDS
namespace Ian.Core.Interfaces;

using System.Reflection.Metadata;
using Ian.Core.Models;
using Ian.Core.Requests;

public interface IAccountService
{
    Task<Guid?> GetAccountID(ulong UserId, string AccountName);

    Task<Account?> GetAccount(Guid AccountId); //

    Task<Account> CreateAccount(CreateAccountRequest request);

    Task <decimal> GetBalance(Guid AccountId);

    Task<List<LedgerEntry>> GetAccountHistory(Guid accountId);

    Task<List<Account>> GetAllAccounts(ulong UserId);
}