using Mapster;
using XWear.Application.Features.Authentication.Common;
using XWear.Contracts.Authetication.Responses;

namespace XWear.Application.Common.Mapping
{
    public class AuthMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AuthenticationResult, AuthResponse>();
        }
    }
}
