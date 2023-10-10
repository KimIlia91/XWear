using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.ValueObjects;

public sealed class UserId : ValueObject
{
    public Guid Value { get; set; }

    private UserId(Guid value)
    {
        Value = value;
    }

    public static UserId CreateUnique()
    {
        return new UserId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
