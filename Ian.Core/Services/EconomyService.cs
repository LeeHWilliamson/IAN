using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Models;
using Ian.Core.Enums;
using System.Xml.Schema;
using System.Runtime.InteropServices.Swift;

namespace Ian.Core.Services;

public class EconomyService : IEconomyService
{
    public Task<LedgerEntry> CreateLedgerEntry(TransferRequest request, TransactionType type)
    {
        var entry = new LedgerEntry();
        entry.Id = ????
        entry.SenderAccountId = request.SenderAccountId;
        entry.ReceiverAccountId = request.ReceiverAccountId;
        entry.Amount = request.Amount;
        entry.TransactionType = type;
        entry.Metadata = ???;
        entry.CreatedAt = ???;
    }
    public async Task<bool> Transfer(TransferRequest request)
    {
        // verify both users exist
        var senderExists = await UserService.UserExists(request.SenderDiscordId);
        var receiverExists = await UserService.UserExists(request.ReceiverDiscordId);
        if (!senderExists || !receiverExists)
        {
            return false;
        }
        // verify both accounts exist
        request.SenderAccountId = AccountService.AccountExists(request.SenderDiscordId, request.SenderAccountName)
        request.ReceiverAccountId = AccountService.AccountExists(request.ReceiverDiscordId, request.ReceiverAccountName)
        // verify sender has the skrilla
        var senderBalance = await AccountService.GetBalance(request.SenderAccountId);
        if senderBalance < request.Amount
        {
            return false;
        }
        // Assemble ledger entry
        var entry = CreateLedgerEntry(request, "Transfer");
        // Attempt to update ledger
        var ledgerUpdated = UpdateLedger(entry);
    }

    public Task<bool> UpdateLedger(LedgerEntry entry)
    {
        //attempt to update the ledger
    }
}