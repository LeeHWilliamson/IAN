namespace Ian.Core.Interfaces;

public interface ILedger
{
    public List<ILedgerEntry> LedgerEntries { get; }

    public void UpdateLedger(ILedgerEntry entry);
}