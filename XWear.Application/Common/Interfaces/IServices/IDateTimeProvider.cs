namespace XWear.Application.Common.Interfaces.IServices;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
