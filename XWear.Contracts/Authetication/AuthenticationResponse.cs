namespace XWear.Contracts.Authetication;

public record AuthenticationResponse(
    Guid Id,
    string Email,
    string accessToken,
    string refreshToken);
