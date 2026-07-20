namespace Ian.Core.Interfaces;

using Ian.Core.Models;
using Ian.Core.Requests;

public interface IEconomyService
{
    Task Transfer(TransferRequest request);

    Task UpdateLedger(LedgerEntry entry);
}