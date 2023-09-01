using XWear.Application.Common.Interfaces;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();

        public UserRepository()
        {
            _users.Add(new User
            {
                FirstName = "Данияр",
                LastName = "Даниярович",
                Email = "testuser@test.com",
                Password = "TestUser123!",
            });
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }
    }
}
