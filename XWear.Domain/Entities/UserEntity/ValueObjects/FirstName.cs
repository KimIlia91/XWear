using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.UserEntity.ValueObjects;

public sealed class FirstName : ValueObject
{
    public string Value { get; private set; } = null!;

    private FirstName(
        string value)
    {
        Value = value;
    }

    public static ErrorOr<FirstName> Create(string firstName)
    {
        if (string.IsNullOrEmpty(firstName) || firstName.Length > EntityConstants.FirstNameLength)
            return Errors.User.InvalidFirstName;

         return new FirstName(firstName);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
