using Ian.Core.Interfaces;

namespace Ian.Application.Models;

public class Ledger : ILedger
{
    public List<ILedgerEntry> LedgerEntries { get; private set; }

    public Ledger()
    {
        LedgerEntries = new();
    }

    public void UpdateLedger(ILedgerEntry entry)
    {
        LedgerEntries.Add(entry);
    }

    private void WriteToLedger(ILedgerEntry entry)
    {
        // what IS the ledger? Is text file? A private discord thread?
    }
}