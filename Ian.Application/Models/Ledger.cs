using System.Diagnostics.Tracing;
using Ian.Core.Infrastructure;
using Ian.Core.Interfaces;
using Ian.Primitives.Events;

namespace Ian.Application.Models;

public class Ledger : ILedger
{
    public List<ILedgerEntry> LedgerEntries { get; private set; }
    private IEventBus _eventBus;
    public Ledger(IEventBus eventBus)
    {
        _eventBus = eventBus;
        _eventBus.Subscribe<AddLedgerEntryEvent>(HandleLedgerEvent);

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

    private void HandleLedgerEvent(AddLedgerEntryEvent evt)
    {
        UpdateLedger(evt.Data);
    }
}