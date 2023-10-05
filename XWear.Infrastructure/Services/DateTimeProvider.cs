using XWear.Application.Common.Interfaces.IServices;

namespace XWear.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
