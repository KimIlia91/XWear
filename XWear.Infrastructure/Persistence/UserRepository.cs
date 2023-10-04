﻿using XWear.Application.Common.Interfaces;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();

        public UserRepository()
        {
            if (_users.Count == 0)
            {
                _users.Add(new User
                {
                    FirstName = "Данияр",
                    LastName = "Даниярович",
                    Email = "testuser@test.com",
                    Phone = "+996709123123",
                    Password = "TestUser123!",
                });
            }
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }

        public User? GetUserById(Guid id)
        {
            return _users.SingleOrDefault(u => u.Id == id);
        }

        public bool IsEmailUnique(string email, Guid userId)
        {
            var user = _users.SingleOrDefault(u => u.Email == email && u.Id != userId);

            return user is null;
        }
    }
}
