using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail => Error.Conflict(
            code: ErrorResources.UserDuplicateEmail, 
            description: PropertyResources.UserDuplicateEmail);

        public static Error InvalidFirstName => Error.Conflict(
            code: string.Format(ErrorResources.InvalidStringLength, EntityConstants.FirstNameLength),
            description: PropertyResources.UserFirstName);

        public static Error InvalidLastName => Error.Conflict(
            code: string.Format(ErrorResources.InvalidStringLength, EntityConstants.LastNameLength),
            description: PropertyResources.UserLastName);

        public static Error InvalidEmailLength => Error.Conflict(
            code: string.Format(ErrorResources.InvalidStringLength, EntityConstants.EmailLength),
            description: PropertyResources.UserEmail);

        public static Error InvalidEmailFormat => Error.Conflict(
            code: ErrorResources.InvalidEmailFormat,
            description: PropertyResources.UserEmail);

        public static Error InvalidPasswordLength => Error.Conflict(
            code: string.Format(ErrorResources.InvalidStringLength, EntityConstants.PasswordLength),
            description: PropertyResources.Password);

        public static Error InvalidPhoneLength => Error.Conflict(
           code: ErrorResources.Requred,
           description: PropertyResources.Phone);
    }
}