namespace Ian.Core.Interfaces;

using Ian.Core.Models;
using Ian.Core.Requests;

public interface IEconomyService
{
    Task<bool> Transfer(TransferRequest request);

    Task<LedgerEntry> CreateLedgerEntry(TransferRequest request);
    
    Task<bool> UpdateLedger(LedgerEntry entry);
}