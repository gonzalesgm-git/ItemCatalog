using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Item.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemDbContext _dbContext;
        public ItemRepository(ItemDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Models.Item> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Domain.Models.Item>> GetItemsAsync()
        {
            return await _dbContext.Items.ToListAsync();
        }

        public Task<Domain.Models.Item> SaveitemAsync(Domain.Models.Item item)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Domain.Models.Item item)
        {
            throw new NotImplementedException();
        }
    }
}
