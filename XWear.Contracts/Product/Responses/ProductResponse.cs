namespace XWear.Contracts.Product.Responses
{
    public record ProductResponse(
        Guid Id,
        string Model,
        string ImgUrl,
        decimal Price);
}
