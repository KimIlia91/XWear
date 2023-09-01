using ErrorOr;
using MediatR;
using XWear.Application.Authentication.Common;

namespace XWear.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
