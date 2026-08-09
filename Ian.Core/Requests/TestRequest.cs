using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct TestRequest : IRequest
{

    public Type RequestType => typeof(TestRequest);

    public TestRequest()
    {
        // put data needed to evaluate your request in here
    }
}