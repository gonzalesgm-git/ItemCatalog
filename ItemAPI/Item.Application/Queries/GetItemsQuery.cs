﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Queries
{
    public class GetItemsQuery: IRequest<List<Item.Domain.Models.Item>> { }
   
}