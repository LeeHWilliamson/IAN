using Ian.Primitives.Transactions;

namespace Ian.Core.Transactions;

public interface IDepositable
{
    public void Deposit(Transaction transaction);
}