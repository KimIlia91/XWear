namespace XWear.Contracts.Product;

public record ProductResponse(
    Guid Id,
    string Name,
    string Img,
    decimal Price);
