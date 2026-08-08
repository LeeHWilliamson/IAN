using Ian.Primitives.Transactions;

namespace Ian.Core.Transactions;

public interface IWithdrawable
{
    public Transaction Withdraw(Transaction transaction);
}