using ErrorOr;
using MediatR;
using XWear.Application.Features.Authentication.Common;

namespace XWear.Application.Features.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string Password,
    string ConfirmPassword) : IRequest<ErrorOr<AuthenticationResult>>;
