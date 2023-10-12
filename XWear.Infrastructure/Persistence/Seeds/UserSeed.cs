using XWear.Domain.Entities.UserEntity;

namespace XWear.Infrastructure.Persistence.Seeds
{
    internal class UserSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = CreateUsers();
                await context.Users.AddRangeAsync(users);
                await context.SaveChangesAsync();
            }
        }

        private static List<User> CreateUsers()
        {
            var users = new List<User>()
            {
                User.Create(
                   "Данияр",
                   "Даниярович",
                   "testuser@test.com",
                   "+996709123123",
                   "TestUser123!").Value
            };

            return users;
        }
    }
}
