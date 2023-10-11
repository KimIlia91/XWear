using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class Brand
    {
        public static Error InvalidNameLength => Error.Validation(
               code: PropertyResources.BrandName,
               description: string.Format(ErrorResources.InvalidStringLength, EntityConstants.CatalogNameLength));
    }
}
