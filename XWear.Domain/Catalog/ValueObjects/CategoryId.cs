using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.ValueObjects;

public sealed class CategoryId : ValueObject
{
    public Guid Value { get; private set; }

    private CategoryId(Guid value)
    {
        Value = value;
    }

    public static CategoryId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
