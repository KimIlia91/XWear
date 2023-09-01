namespace XWear.Application.Features.Authentication.Common
{
    public record AuthenticationResult(
        string Email,
        string AccessToken,
        string RefreshToken);
}