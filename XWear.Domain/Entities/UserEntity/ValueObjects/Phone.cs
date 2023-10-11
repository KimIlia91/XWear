using ErrorOr;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.UserEntity.ValueObjects;

public sealed class Phone : ValueObject
{
    public string Value { get; private set; } = null!;

    public Phone(
        string value)
    {
        Value = value;
    }

    public static ErrorOr<Phone> Create(string value)
    {
        if (string.IsNullOrEmpty(value))
            return Errors.User.InvalidPhoneLength;

        return new Phone(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
