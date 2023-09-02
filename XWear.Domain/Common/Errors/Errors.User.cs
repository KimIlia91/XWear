using ErrorOr;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail => Error.Conflict(
            code: ErrorResources.UserDuplicateEmail, 
            description: PropertyResources.UserDuplicateEmail);
    }
}