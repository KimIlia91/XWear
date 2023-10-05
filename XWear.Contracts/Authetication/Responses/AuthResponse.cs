namespace XWear.Contracts.Authetication.Responses;

public record AuthResponse(
    string Email,
    string AccessToken,
    string RefreshToken);
