using ErrorOr;
using System.Text.RegularExpressions;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.UserEntity.ValueObjects;

public sealed class Email : ValueObject
{
    public string Value { get; set; } = null!;

    private Email(
        string email)
    {
        Value = email;
    }

    public static ErrorOr<Email> Create(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length > EntityConstants.EmailLength)
            return Errors.User.InvalidEmailLength;

        var regex = new Regex(RegexConstants.Email, RegexOptions.IgnoreCase);

        if (!regex.IsMatch(value))
            return Errors.User.InvalidEmailFormat;

        return new Email(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
