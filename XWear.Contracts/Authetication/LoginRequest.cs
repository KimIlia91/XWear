namespace XWear.Contracts.Authetication;

public record LoginRequest(
    string Email,
    string Password);
