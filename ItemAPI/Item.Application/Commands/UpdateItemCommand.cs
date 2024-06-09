using MediatR;

namespace Item.Application.Commands
{
    public record UpdateItemCommand(Item.Domain.Models.Item item) : IRequest<Item.Domain.Models.Item>;
}
