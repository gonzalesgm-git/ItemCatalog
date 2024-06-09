﻿using Item.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Commands
{
    internal class SaveItemCommandHandler : IRequestHandler<SaveItemCommand, Item.Domain.Models.Item>
    {
        private readonly IItemRepository _itemRepository;

        public SaveItemCommandHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task<Domain.Models.Item> Handle(SaveItemCommand command, CancellationToken cancellationToken)
        {
            var res =  await _itemRepository.SaveitemAsync(command.item);
            return command.item;
        }
    }
}
