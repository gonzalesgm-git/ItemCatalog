using Item.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Queries
{
    public class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, IEnumerable<Domain.Models.Item>>
    {
        private readonly IItemRepository _itemRepository;

        public GetItemsQueryHandler(IItemRepository itemRepository) { 
            _itemRepository = itemRepository;
        }
        public async Task<IEnumerable<Domain.Models.Item>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            return await _itemRepository.GetItemsAsync();
        }
    }
}
