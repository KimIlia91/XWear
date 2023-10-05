namespace XWear.Contracts.Product.Responses;

public record ProductResponse(
    Guid Id,
    string Name,
    string Img,
    decimal Price);
