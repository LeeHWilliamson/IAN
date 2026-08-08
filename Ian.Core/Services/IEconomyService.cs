using Ian.Core.Interfaces;
using Ian.Core.Requests;

namespace Ian.Core.Services;

public interface IEconomyService
{
    Task<bool> Transfer(TransferRequest request);

    Task<ILedgerEntry> CreateLedgerEntry(TransferRequest request);

    Task<bool> UpdateLedger(ILedgerEntry entry);
}