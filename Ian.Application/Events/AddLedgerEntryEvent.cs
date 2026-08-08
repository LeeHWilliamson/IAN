using Ian.Application.Models;
using Ian.Core.Interfaces;

namespace Ian.Primitives.Events;

public record AddLedgerEntryEvent
{
    public ILedgerEntry Data { get; private set; }

    public AddLedgerEntryEvent(ILedgerEntry data) => Data = data;
}