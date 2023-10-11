using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class Color
    {
        public static Error InvalidNameLength => Error.Validation(
               code: PropertyResources.InvalidStringLength,
               description: string.Format(ErrorResources.InvalidStringLength, EntityConstants.ColorNameLength));

        public static Error ColorNotFound => Error.Validation(
               code: PropertyResources.ColorNotFound,
               description: ErrorResources.ColorNotFound);
    }
}
