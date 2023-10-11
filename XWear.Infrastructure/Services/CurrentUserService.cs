using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Infrastructure.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private UserId? _userId;

    public UserId UserId
    {
        get
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (_httpContextAccessor.HttpContext.User.HasClaim(x => x.Type == ClaimTypes.NameIdentifier))
            {
#pragma warning disable CS8604 // Possible null reference argument.
                var guidUserId = Guid.Parse(
                    _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
#pragma warning restore CS8604 // Possible null reference argument.

                if (guidUserId != Guid.Empty)
                {
                    _userId = UserId.ConvertFromGuid(guidUserId);

                    return _userId;
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            return UserId.CreateEmpty();
        }
    }

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
}
