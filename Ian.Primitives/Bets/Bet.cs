namespace Ian.Primitives.Bets;

public struct Bet
{
    ulong Challenger;
    ulong Challenged;
    ulong Arbiter;
    string Terms;
    decimal Amount;
}