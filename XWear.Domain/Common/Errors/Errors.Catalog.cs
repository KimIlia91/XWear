using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class Catalog
        {
            public static Error InvalidNameLength => Error.Validation(
                code: PropertyResources.CatalogName,
                description: string.Format(ErrorResources.InvalidStringLength, EntityConstants.CatalogNameLength));
        }
    }
}
