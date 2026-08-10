using Ian.Primitives.Bets;

namespace Ian.Core.Services;

public interface IBetService
{
    public Task LogBetAcceptedAsync(Bet bet);
}