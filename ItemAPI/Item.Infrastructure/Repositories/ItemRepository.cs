using Microsoft.EntityFrameworkCore;

namespace Item.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemDbContext _dbContext;
        public ItemRepository(ItemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var itemToDelete = GetItem(id);
             _dbContext.Items.Remove(itemToDelete);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public Domain.Models.Item GetItem(int id)
        {
            return  _dbContext.Items.Where(x => x.Id == id).First();
        }

        public async Task<IEnumerable<Domain.Models.Item>> GetItemsAsync()
        {
            return await _dbContext.Items.ToListAsync();
        }

        public async Task<bool> SaveitemAsync(Domain.Models.Item item)
        {
            await _dbContext.Items.AddAsync(item);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateItemAsync(Domain.Models.Item item)
        {
            _dbContext.Items.Update(item);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
