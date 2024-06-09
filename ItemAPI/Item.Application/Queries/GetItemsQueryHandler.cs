using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Queries
{
    public class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, List<Item.Domain.Models.Item>>
    {
        public Task<List<Domain.Models.Item>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
