using Mapster;
using XWear.Application.Features.Authentication.Common;
using XWear.Contracts.Authetication.Responses;

namespace XWear.Application.Common.Mapping.Auth
{
    public class AuthMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AuthenticationResult, AuthResponse>();
        }
    }
}
