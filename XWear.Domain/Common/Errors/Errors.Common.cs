using ErrorOr;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class Common
    {
        public static Error NotFound => Error.Validation(
             code: PropertyResources.NotFound,
             description: ErrorResources.NotFound);
    }
}
