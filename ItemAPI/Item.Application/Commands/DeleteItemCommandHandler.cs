using Item.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Commands
{
    internal class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand, Item.Domain.Models.Result>
    {
        private readonly IItemRepository _repository;
        public DeleteItemCommandHandler(IItemRepository itemRepository) 
        {
            _repository = itemRepository;
        }
        public async Task<Domain.Models.Result> Handle(DeleteItemCommand command, CancellationToken cancellationToken)
        {
           await _repository.DeleteItemAsync(command.id);
            return new Domain.Models.Result();
        }
    }
}
