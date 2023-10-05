namespace XWear.Application.Common.Interfaces.IServices
{
    public interface ICurrentUserService
    {
        Guid UserId { get; }

        Guid? NullableUserId { get; }
    }
}
