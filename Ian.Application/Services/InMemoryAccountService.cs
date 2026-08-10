using System.Formats.Asn1;
using Ian.Application.Models;
using Ian.Core.Infrastructure;
using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Core.Services;
using Ian.Data.Entities;
using Ian.Primitives.Accounts;

namespace Ian.Application.Services;

public class InMemoryAccountService : IAccountService
{
    private IEventBus _eventBus;
    private IUserService _userService;
    public InMemoryAccountService(IEventBus eventBus, IUserService userService)
    {
        _eventBus = eventBus;
        _userService = userService;
    }
    public Task<bool> AccountExistsAsync(ulong discordId, string accountName)
    {
        throw new NotImplementedException();
    }

    public async Task<IAccount> CreateAccountAsync(CreateAccountResult request)
    {
        // Put together the data
        AccountData data = new AccountData(request.RequesterId, request.AccountName, request.AccountType);
        // make the account
        IAccount account = new Account(data, _eventBus);
        // Get the user
        IUser user = await _userService.GetUserAsync(request.RequesterId);
        user.Portfolio.AddAccount(account);
        // return the result
        return account;
    }

    public Task<IAccountData?> GetAccountAsync(Guid AccountId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ILedgerEntry>> GetAccountHistoryAsync(Guid accountId)
    {
        throw new NotImplementedException();
    }

    public Task<Guid?> GetAccountIDAsync(ulong UserId, string AccountName)
    {
        throw new NotImplementedException();
    }

    public Task<List<IAccountData>> GetAllAccountsAsync(ulong UserId)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetBalanceAsync(Guid AccountId)
    {
        throw new NotImplementedException();
    }
}