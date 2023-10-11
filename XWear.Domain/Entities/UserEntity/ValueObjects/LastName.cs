using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.UserEntity.ValueObjects
{
    public sealed class LastName : ValueObject
    {
        public string Value { get; private set; } = null!;

        private LastName(
            string value)
        {
            Value = value;
        }

        public static ErrorOr<LastName> Create(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length > EntityConstants.LastNameLength)
                return Errors.User.InvalidLastName;

            return new LastName(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
