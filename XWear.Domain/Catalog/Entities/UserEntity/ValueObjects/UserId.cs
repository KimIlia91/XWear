using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities.UserEntity.ValueObjects;

public sealed class UserId : ValueObject
{
    public Guid Value { get; private set; }

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

    public static UserId ConvertFromGuid(Guid guid)
    {
        return new UserId(guid);
    }

    public static UserId CreateEmpty()
    {
        return new UserId(Guid.Empty);
    }
}
