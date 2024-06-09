using MediatR;

namespace Item.Application.Commands;

public record DeleteItemCommand(int id) : IRequest<Item.Domain.Models.Result>;

