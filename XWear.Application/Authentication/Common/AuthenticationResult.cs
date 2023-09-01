namespace XWear.Application.Authentication.Common
{
    public record AuthenticationResult(
        string Email,
        string AccessToken,
        string RefreshToken);
}