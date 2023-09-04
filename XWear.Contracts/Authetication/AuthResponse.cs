namespace XWear.Contracts.Authetication;

public record AuthenticationResponse(
    string Email,
    string AccessToken,
    string RefreshToken);
