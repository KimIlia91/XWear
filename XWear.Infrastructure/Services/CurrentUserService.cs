using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using XWear.Application.Common.Interfaces;

namespace XWear.Infrastructure.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private Guid? _userId;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid? NullableUserId =>
        _httpContextAccessor.HttpContext.User.HasClaim(x => x.Type == ClaimTypes.NameIdentifier)
            ? Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier))
            : default;

    public Guid UserId
    {
        get
        {
            if (_httpContextAccessor.HttpContext.User.HasClaim(x => x.Type == ClaimTypes.NameIdentifier))
            {
                _userId ??= Guid.Parse(
                    _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                return _userId.Value;
            }

            throw new UnauthorizedAccessException();
        }
    }
}
