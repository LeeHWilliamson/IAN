using Ian.Core.Interfaces;
using Ian.Core.Results;

namespace Ian.Application.ResultHandling;

public class ResultHandler : IResultHandler
{
    private List<string> _messages = new();

    public string EvaluateResult(IResult result)
    {
        List<string> message = EvaluateResults(new List<IResult> { result });
        return message[0];
    }

    public List<string> EvaluateResults(List<IResult> results)
    {
        _messages.Clear();
        for (int i = 0; i < results.Count; i++)
        {
            var result = results[i];
            if (!result.Approved)
            {
                // tell the user the request was denied
                _messages.Add($"Request denied");
                continue;
            }
            switch (result)
            {
                case AccountBalanceResult balanceResult:
                    {
                        // Get the account balance as a string
                        break;
                    }
                case CreateAccountResult createResult:
                    {
                        // Create an account and notify the user
                        break;
                    }
                case GetTransactionHistoryResult historyResult:
                    {
                        // Get the transaction history for a given account
                        break;
                    }
                case TransferResult transferResult:
                    {
                        // Transfer IAN coin between 2 accounts and notify the user
                        break;
                    }
                // FOR THE LOVE OF DOG DO NOT DELETE THE MARKER
                case TestResult TestResult_:
                    {
                        // handle the results
                        break;
                    }
                // --- NEW-CASE-MARKER ---
                default:
                    {
                        Console.WriteLine($"{result.ResultType} was unhandled by the Result handler.");
                        break;
                    }
            }
        }
        // this feedback for the user about what happened with their request.
        return _messages;
    }
}
