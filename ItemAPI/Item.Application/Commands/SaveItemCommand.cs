using MediatR;

namespace Item.Application.Commands;

public record SaveItemCommand(Item.Domain.Models.Item item) : IRequest<Item.Domain.Models.Item>;
