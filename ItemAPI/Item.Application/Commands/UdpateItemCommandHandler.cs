using Item.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Commands
{
    internal class UdpateItemCommandHandler : IRequestHandler<UpdateItemCommand, Item.Domain.Models.Item>
    {
        private readonly IItemRepository _itemRepository;
        public UdpateItemCommandHandler(IItemRepository repository) 
        {
            _itemRepository = repository;
        }
        public  async Task<Domain.Models.Item> Handle(UpdateItemCommand command, CancellationToken cancellationToken)
        {
            var res = await _itemRepository.UpdateItemAsync(command.item);
            return command.item;
        }
    }
}
