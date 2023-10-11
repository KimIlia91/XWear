using ErrorOr;
using MediatR;
using XWear.Domain.Entities.ColorEntity.ValueObjects;

namespace XWear.Application.Features.ColorContext.Commands;

public sealed record CreateColorCommand(string Name) : IRequest<ErrorOr<ColorId>>;
