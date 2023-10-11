using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ImageEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity.ValueObjects;

namespace XWear.Domain.Entities.ImageEntity;

public sealed class Image : Entity<ImageId>
{
    public string Name { get; private set; } = null!;

    public ImageUrl ImgUrl { get; private set; }

    public ProductId ProductId { get; private set; }

    internal Image(
        ImageId id,
        ImageUrl imgUrl,
        ProductId productId,
        string name) 
        : base(id)
    {
        Id = id;
        ImgUrl = imgUrl;
        ProductId = productId;
        Name = name;
    }

    public static ErrorOr<Image> Create(string name, ProductId productId)
    {
        if (string.IsNullOrEmpty(name) || name.Length > EntityConstants.ImageNameLength)
            return Common.Errors.Errors.Image.InvalidNameLength;

        var imageResult = ImageUrl.Create(name);

        if (imageResult.IsError)
            return imageResult.Errors;

        return new Image(ImageId.CreateUnique(), imageResult.Value, productId, name);
    }
}
