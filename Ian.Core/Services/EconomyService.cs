using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Models;

namespace Ian.Core.Services;

public class EconomyService : IEconomyService
{
    public Task<Account> CreateAccount(CreateAccountRequest request)
    {
        //check if user exists in users table
        var userExists = GetUser(request.RequesterUserId);

        if userExists
        {
            
        }
        throw new NotImplementedException();
    }

    public Task Transfer(TransferRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetBalance(Guid accountId)
    {
        throw new NotImplementedException();
    }

    public Task<List<LedgerEntry>> GetTransactionHistory(Guid accountId)
    {
        throw new NotImplementedException();
    }
}