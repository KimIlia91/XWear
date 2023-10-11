using ErrorOr;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ImageEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity.ValueObjects;

namespace XWear.Domain.Entities.ImageEntity;

public sealed class Image : Entity<ImageId>
{
    public ImageUrl ImgUrl { get; private set; }

    public ProductId ProductId { get; private set; }

    private Image() : base(ImageId.CreateUnique())
    {
    }

    internal Image(
        ImageId id,
        ImageUrl imgUrl,
        ProductId productId) 
        : base(id)
    {
        Id = id;
        ImgUrl = imgUrl;
        ProductId = productId;
    }

    public static ErrorOr<Image> Create(string imgUrl, ProductId productId)
    {
        var imageResult = ImageUrl.Create(imgUrl);

        if (imageResult.IsError)
            return imageResult.Errors;

        return new Image(ImageId.CreateUnique(), imageResult.Value, productId);
    }
}
