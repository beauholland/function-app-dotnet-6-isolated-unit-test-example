using Microsoft.Azure.Functions.Worker;

namespace TestProject1.Mock;
public class MockBindingMetadata : BindingMetadata
{
    public MockBindingMetadata(string name, string type, BindingDirection direction)
    {
        Name = name;
        Type = type;
        Direction = direction;
    }

    public override string Name { get; }

    public override string Type { get; }

    public override BindingDirection Direction { get; }
}
