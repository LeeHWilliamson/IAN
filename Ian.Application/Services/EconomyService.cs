using Ian.Application.Models;
using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Primitives.Transactions;

namespace Ian.Core.Services;

public class EconomyService : IEconomyService
{
    private IUserService _userService;
    private IAccountService _accountService;
    public EconomyService(IUserService userService, IAccountService accountService)
    {
        _userService = userService;
        _accountService = accountService;
    }
    // public async Task<ILedgerEntry> CreateLedgerEntry(TransferRequest request, TransactionType type)
    // {
    //     var entry = new LedgerEntry();
    //     Console.WriteLine($"Implement sending the proper Id!");
    //     entry.Id = request.SenderAccountId;
    //     entry.SenderAccountId = request.SenderAccountId;
    //     entry.ReceiverAccountId = request.ReceiverAccountId;
    //     entry.Amount = request.Amount;
    //     entry.TransactionType = type;
    //     Console.WriteLine($"Implement sending meta data!");
    //     entry.Metadata = "???";
    //     entry.CreatedAt = DateTime.Now;
    //     return entry;
    // }

    // public Task<ILedgerEntry> CreateLedgerEntry(TransferRequest request)
    // {
    //     throw new NotImplementedException();
    // }

    public async Task<bool> Transfer(TransferRequest request)
    {
        // validate sender and receivers
        bool senderExists = await _userService.UserExistsAsync(request.SenderDiscordId);
        bool receiverExists = await _userService.UserExistsAsync(request.ReceiverDiscordId);


        if (!senderExists || !receiverExists)
        {
            return false;
        }
        // verify both accounts exist
        // request.SenderAccountId = _accountService.AccountExists(request.SenderDiscordId, request.SenderAccountName);
        // request.ReceiverAccountId = _accountService.AccountExists(request.ReceiverDiscordId, request.ReceiverAccountName);

        bool sendAccountExists = await _accountService.AccountExistsAsync(
            request.SenderDiscordId,
            request.SenderAccountName);

        bool receiverAccountExists = await _accountService.AccountExistsAsync(
            request.ReceiverDiscordId,
            request.ReceiverAccountName);

        if (!sendAccountExists || !receiverAccountExists)
        {
            return false;
        }

        // verify sender has the skrilla
        decimal senderBalance = await _accountService.GetBalanceAsync(request.SenderAccountId);
        if (senderBalance < request.Amount)
        {
            return false;
        }
        // Create the ledger entry task
        // ILedgerEntry entry = await CreateLedgerEntry(request, TransactionType.Transfer);


        // Attempt to update ledger
        // bool ledgerUpdated = await UpdateLedger(entry);
        Console.WriteLine($"Transfer method always returns true because it is empty. This is a place holder.");
        return true;
    }

    public async Task<bool> UpdateLedger(ILedgerEntry entry)
    {
        //attempt to update the ledger
        Console.WriteLine($"Method UpdateLedger always returns true because it is empty. This is a place holder.");
        return true;
    }
}