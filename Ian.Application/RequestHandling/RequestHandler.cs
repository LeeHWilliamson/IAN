using System.Runtime.InteropServices;
using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Core.Rules;
using Ian.Core.Services;

namespace Ian.Application.RequestHandling;

public class RequestHandler : IRequestHandler
{
    private List<IResult> _results = new();
    private IUserService _userService;
    private IAccountService _accountService;

    public RequestHandler(IUserService userService, IAccountService accountService)
    {
        _userService = userService;
        _accountService = accountService;
    }


    public async Task<IResult> EvaluateRequestAsync(IRequest request)
    {
        List<IResult> results = await EvaluateRequestsAsync(new List<IRequest> { request });
        return results[0];
    }

    public async Task<List<IResult>> EvaluateRequestsAsync(List<IRequest> requests)
    {
        _results.Clear();
        for (int i = 0; i < requests.Count; i++)
        {
            var request = requests[i];

            switch (request)
            {
                case AccountBalanceRequest balanceRequest:
                    {
                        _results.Add(AccountBalanceRules.Evaluate(balanceRequest));
                        break;
                    }
                case CreateAccountRequest createRequest:
                    {
                        CreateAccountResult res = await CreateAccountRules.Evaluate(createRequest, _userService, _accountService);
                        _results.Add(res);
                        break;
                    }
                case GetTransactionHistoryRequest historyRequest:
                    {
                        _results.Add(GetTransactionHistoryRules.Evaluate(historyRequest));
                        break;
                    }
                case TransferRequest transferRequest:
                    {
                        _results.Add(TransferRules.Evaluate(transferRequest));
                        break;
                    }
                case AddUserRequest addUserRequest:
                    {
                        AddUserResult res = await AddUserRules.Evaluate(addUserRequest, _userService);
                        _results.Add(res);
                        break;
                    }
                // FOR THE LOVE OF DOG DO NOT DELETE THE MARKER
                // --- NEW-CASE-MARKER ---
                default:
                    {
                        Console.WriteLine($"{request.RequestType} was unhandled by the request handler.");
                        break;
                    }
            }
        }
        return _results;
    }
}



