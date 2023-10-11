﻿using Mapster;
using XWear.Domain.Entities.UserEntity;

namespace XWear.Application.Features.Account.Common
{
    public class AccountResult : IRegister
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<User, AccountResult>()
                .Map(dest => dest.FirstName, src => src.FirstName.Value)
                .Map(dest => dest.LastName, src => src.LastName.Value)
                .Map(dest => dest.Phone, src => src.Phone.Value)
                .Map(dest => dest.Email, src => src.Email.Value);
        }
    }
}
