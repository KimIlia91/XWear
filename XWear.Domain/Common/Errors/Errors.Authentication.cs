using ErrorOr;

namespace XWear.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class Authentication
        {
            public static Error InvalidCredentinals => Error.Validation(
                code: "User.InvalidCred",
                description: "Invalid credentinals.");
        }
    }
}
