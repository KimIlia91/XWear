using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        User? GetUserById(Guid id);

        void Add(User user);
    }
}
