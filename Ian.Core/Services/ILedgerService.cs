using Ian.Core.Interfaces;

namespace Ian.Core.Services;

public interface ILedgerService
{
    public void UpdateLedger(ILedgerEntry entry);
}