using ErrorOr;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class Product
    {
        public static Error FavoritProductExist => Error.Conflict(
            code: ErrorResources.FavoritProductExist,
            description: PropertyResources.FavoritProductExist);
    }
}
