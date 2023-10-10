using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ModelEntity.ValueObjects;

public sealed class ModelName : ValueObject
{
    public string Value { get; private set; }

    private ModelName(string value)
    {
        Value = value;
    }

    public static ModelName CreateName(string name)
    {
        return new(name);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
