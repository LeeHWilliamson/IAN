using Ian.Core.Transactions;
using Ian.Primitives.Accounts;

namespace Ian.Core.Interfaces;

public interface IAccount : IAccountData, IWithdrawable, IDepositable
{

}