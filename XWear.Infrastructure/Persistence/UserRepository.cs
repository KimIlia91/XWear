using XWear.Application.Common.Interfaces;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User? GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
