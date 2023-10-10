using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Infrastructure.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private UserId _userId;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid? NullableUserId =>
        _httpContextAccessor.HttpContext.User.HasClaim(x => x.Type == ClaimTypes.NameIdentifier)
            ? Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier))
            : default;

    public UserId UserId
    {
        get
        {
            if (_httpContextAccessor.HttpContext.User.HasClaim(x => x.Type == ClaimTypes.NameIdentifier))
            {
                var guidUserId = Guid.Parse(
                    _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

                if (guidUserId != Guid.Empty)
                {
                    _userId = UserId.ConvertFromGuid(guidUserId);

                    return _userId;
                }
            }

            return UserId.CreateEmpty();
        }
    }
}
