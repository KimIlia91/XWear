using XWear.Domain.Catalog.ValueObjects;

namespace XWear.Application.Common.Interfaces.IServices
{
    public interface ICurrentUserService
    {
        UserId UserId { get; }

        Guid? NullableUserId { get; }
    }
}
