using ErrorOr;
using System.Text.RegularExpressions;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.UserEntity.ValueObjects
{
    public sealed class Password : ValueObject
    {
        public string Value { get; set; } = null!;

        private Password(
            string value)
        {
            Value = value;
        }

        public static ErrorOr<Password> Create(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length > EntityConstants.PasswordLength)
                return Errors.User.InvalidPasswordLength;

            var regex = new Regex(RegexConstants.PasswordPolicyValidatorRegex, RegexOptions.IgnoreCase);

            if (!regex.IsMatch(value))
                return Errors.Authentication.InvalidPasswordPolicy;

            return new Password(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
