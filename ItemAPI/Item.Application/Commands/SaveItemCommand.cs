using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Commands;

public record SaveItemCommand(Item.Domain.Models.Item item) : IRequest<Item.Domain.Models.Item>;
