using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Item.Infrastructure.Repositories
{
    public class ItemRepository
    {
        private readonly ItemDbContext _dbContext;
        public ItemRepository(ItemDbContext dbContext)
        {
            _dbContext = dbContext; 
        }
    }
}
