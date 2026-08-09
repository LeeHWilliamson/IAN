using System.Runtime.InteropServices;
using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Rules;

namespace Ian.Application.RequestHandling;

public class RequestHandler : IRequestHandler
{
    private List<IResult> _results = new();

    public IResult EvaluateRequest(IRequest request)
    {
        List<IResult> results = EvaluateRequests(new List<IRequest> { request });
        return results[0];
    }

    public List<IResult> EvaluateRequests(List<IRequest> requests)
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
                        _results.Add(CreateAccountRules.Evaluate(createRequest));
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
                // FOR THE LOVE OF DOG DO NOT DELETE THE MARKER
                case TestRequest TestRequest_:
                    {
                        _results.Add(TestRules.Evaluate(TestRequest_));
                        break;
                    }
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



