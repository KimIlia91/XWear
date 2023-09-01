using ErrorOr;
using MediatR;
using XWear.Domain.Entities;
using XWear.Domain.Common.Errors;
using XWear.Application.Common.Interfaces;
using XWear.Application.Authentication.Common;

namespace XWear.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(
        IUserRepository userRepository,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(
    LoginQuery query,
        CancellationToken cancellationToken)
    {
        if (_userRepository.GetUserByEmail(query.Email) is not User user)
            return Errors.Authentication.InvalidCredentinals;

        if (user.Password != query.Password)
            return Errors.Authentication.InvalidCredentinals;

        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user.Email, token, token);
    }
}
