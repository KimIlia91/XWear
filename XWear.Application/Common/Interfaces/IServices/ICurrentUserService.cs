using XWear.Domain.EntitiesCatalog.Entities.UserEntity.ValueObjects;

namespace XWear.Application.Common.Interfaces.IServices
{
    public interface ICurrentUserService
    {
        UserId UserId { get; }

        Guid? NullableUserId { get; }
    }
}
