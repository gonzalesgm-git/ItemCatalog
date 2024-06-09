using MediatR;

namespace Item.Application.Queries
{
    public class GetItemsQuery: IRequest<IEnumerable<Item.Domain.Models.Item>> { }
   
}
