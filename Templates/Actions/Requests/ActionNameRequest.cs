using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct ActionNameRequest : IRequest
{

    public Type RequestType => typeof(ActionNameRequest);

    public ActionNameRequest()
    {
        // put data needed to evaluate your request in here
    }
}