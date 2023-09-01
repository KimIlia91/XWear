namespace XWear.Application.Authentication.Common
{
    public record AuthenticationResult(
        Guid Id,
        string Email,
        string Token,
        string RefreshToken);
}
