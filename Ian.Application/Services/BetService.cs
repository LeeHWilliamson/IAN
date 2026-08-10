using System.Data;
using System.Runtime.CompilerServices;
using Ian.Core.Services;
using Ian.Primitives.Bets;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Ian.Application.Services;

public class BetService : IBetService
{
    private IConfiguration _config;
    private string _betsChannelId;
    public BetService(IConfiguration config)
    {
        _config = config;
        _betsChannelId = _config["BetsChannelId"];
        Log.Information($"Bets channel id: {_betsChannelId}");
        if (_betsChannelId == null)
        {
            throw new DataException($"BetsChannelId not found in config file");
        }
    }
    public Task LogBetAcceptedAsync(Bet bet)
    {
        throw new NotImplementedException();
    }
}