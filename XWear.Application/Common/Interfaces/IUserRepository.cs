using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        void Add(User user);
    }
}
