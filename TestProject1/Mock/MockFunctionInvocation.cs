using Microsoft.Azure.Functions.Worker;

namespace TestProject1.Mock;
public class MockFunctionInvocation : FunctionInvocation
{
    public MockFunctionInvocation(string id = "", string functionId = "")
    {
        if (!string.IsNullOrWhiteSpace(id))
        {
            Id = id;
        }

        if (!string.IsNullOrWhiteSpace(functionId))
        {
            FunctionId = functionId;
        }
    }

    public override string Id { get; } = Guid.NewGuid().ToString();

    public override string FunctionId { get; } = Guid.NewGuid().ToString();

    public override TraceContext TraceContext { get; } = new DefaultTraceContext(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
}