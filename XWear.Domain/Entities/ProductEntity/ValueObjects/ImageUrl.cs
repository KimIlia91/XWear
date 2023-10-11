using ErrorOr;
using System.Text.RegularExpressions;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ProductEntity.ValueObjects;

public sealed class ImageUrl : ValueObject
{
    public string Value { get; private set; } = null!;

    public ImageUrl(
        string value)
    {
        Value = value;
    }

    public static ErrorOr<ImageUrl> Create(string imgUrl)
    {
        if (string.IsNullOrEmpty(imgUrl) || EntityConstants.ImageUrlLength < imgUrl.Length)
            return Errors.Product.InvalidImgUrl;

        var regex = new Regex(RegexConstants.UrlRegex, RegexOptions.IgnoreCase);

        if (!regex.IsMatch(imgUrl))
            return Errors.Product.InvalidImgUrl;

        return new ImageUrl(imgUrl);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
