using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class Product
    {
        public static Error FavoritProductExist => Error.Validation(
            code: PropertyResources.FavoritProductExist,
            description: ErrorResources.FavoritProductExist);

        public static Error InvalidImgUrl => Error.Validation(
            code: PropertyResources.ImgUrl,
            description: ErrorResources.InvalidImgUrl);

        public static Error InvalidUrlLength => Error.Validation(
            code: PropertyResources.ImgUrl,
            description: string.Format(ErrorResources.InvalidStringLength, EntityConstants.ImageUrlLength));

        public static Error InvalidQuantity => Error.Validation(
           code: PropertyResources.Quantity,
           description: ErrorResources.InvalidQuantity);
    }
}
