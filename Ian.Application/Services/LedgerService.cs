using Ian.Application.Models;
using Ian.Core.Interfaces;
using Ian.Core.Services;

namespace Ian.Application.Services;

public class LedgerService : ILedgerService
{
    private ILedger _ledger;
    public LedgerService(ILedger ledger)
    {
        _ledger = ledger;
    }
    public void UpdateLedger(ILedgerEntry entry)
    {
        _ledger.UpdateLedger(entry);
    }
}