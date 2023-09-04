namespace XWear.Contracts.Authetication;

public record AuthResponse(
    string Email,
    string AccessToken,
    string RefreshToken);
