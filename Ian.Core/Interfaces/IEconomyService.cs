namespace Ian.Core.Interfaces;

using Ian.Core.Models;
using Ian.Core.Requests;

public interface IEconomyService
{
    Task<Account> CreateAccount(CreateAccountRequest request);

    Task Transfer(TransferRequest request);

    Task<decimal> GetBalance(Guid accountId);

    Task<List<LedgerEntry>> GetTransactionHistory(Guid accountId);
}