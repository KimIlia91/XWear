﻿namespace XWear.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Password { get; set; } = null!;

        public virtual ICollection<FavoritProduct> FavoritProducts { get; set; } = new List<FavoritProduct>();
    }
}
