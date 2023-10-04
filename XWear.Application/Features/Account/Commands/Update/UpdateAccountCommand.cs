using ErrorOr;
using MediatR;
using XWear.Contracts.Account;

namespace XWear.Application.Features.Account.Commands.Update;

public record UpdateAccountCommand(
     string FirstName,
     string LastName,
     string Email,
     string Phone) : IRequest<ErrorOr<UpdateAccountResponse>>;
