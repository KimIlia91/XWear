using ErrorOr;
using MediatR;

namespace XWear.Application.Features.Account.Commands.Update;

public record UpdateAccountCommand(
     string FirstName,
     string LastName,
     string Email,
     string Phone) : IRequest<ErrorOr<string>>;
