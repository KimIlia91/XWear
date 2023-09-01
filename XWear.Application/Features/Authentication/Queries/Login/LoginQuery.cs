using ErrorOr;
using MediatR;
using XWear.Application.Features.Authentication.Common;

namespace XWear.Application.Features.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
