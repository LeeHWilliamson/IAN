using Ian.Core.Infrastructure;
using Ian.Core.Interfaces;
using Ian.Primitives.Accounts;
using Ian.Primitives.Events;
using Ian.Primitives.Transactions;

namespace Ian.Application.Models;

public class Account : IAccount
{
    public Guid Id { get; private set; }

    public ulong DiscordId { get; private set; }

    public string AccountName { get; private set; } = "";

    public AccountType AccountType { get; private set; } = AccountType.Peasant;

    public decimal Balance { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public decimal BaseInterestRate { get; private set; }

    private IEventBus _eventBus;
    public Account(AccountData data, IEventBus eventBus)
    {
        Id = new();
        DiscordId = data.DiscordId;
        AccountName = data.AccountName;
        AccountType = data.AccountType;
        Balance = data.Balance;
        BaseInterestRate = data.BaseInterestRate;
        CreatedAt = DateTime.Now;

        _eventBus = eventBus;
    }

    public void Deposit(Transaction transaction)
    {
        if (transaction.TransactionType != TransactionType.Deposit)
        {
            throw new InvalidDataException($"TransactionType must be a Deposit");
        }

        // Add the new amount to the account balance and call it a day
        IncrementBalance(transaction.Amount);

        //update the ledger
        NotifyLedger(transaction);
    }

    public Transaction Withdraw(Transaction transaction)
    {
        if (transaction.TransactionType != TransactionType.Withdraw)
        {
            throw new InvalidDataException($"TransactionType must be a Withdraw");
        }
        decimal withdrawnAmount = 0;
        // Calculate how much was withdrawn
        if (transaction.Amount >= Balance)
        {
            withdrawnAmount = transaction.Amount;
        }
        else
        {
            withdrawnAmount = Balance;
        }

        // always reduce the balance by the transaction amount to over draw accounts
        DecrementBalance(transaction.Amount);

        // Generate a new transaction representing depositing the withdrawn money in another account
        var receipt = new Transaction
        (
            transaction.ReceiverAccountId,
            transaction.SenderAccountId,
            withdrawnAmount,
            TransactionType.Deposit
        );
        //update the ledger
        NotifyLedger(receipt);

        return receipt;
    }

    private void DecrementBalance(decimal amount)
    {
        Balance -= amount;
    }

    private void IncrementBalance(decimal amount)
    {
        Balance += amount;
    }

    private void NotifyLedger(Transaction transaction)
    {
        ILedgerEntry entry = new LedgerEntry(transaction);
        _eventBus.Publish(new AddLedgerEntryEvent(entry));
    }
}