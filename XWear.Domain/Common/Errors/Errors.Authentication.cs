using ErrorOr;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class Authentication
        {
            public static Error InvalidCredentinals => Error.Validation(
                code: PropertyResources.UserInvalidCredentinals,
                description: ErrorResources.UserInvalidCredentinals);

            public static Error InvalidConfirmPassword => Error.Validation(
                code: PropertyResources.InvalidConfirmPassword,
                description: ErrorResources.InvalidConfirmPassword);

            public static Error EmailAlreadyTaken => Error.Validation(
                code: PropertyResources.EmailAlreadyTaken,
                description: ErrorResources.EmailAlreadyTaken);
        }
    }
}
