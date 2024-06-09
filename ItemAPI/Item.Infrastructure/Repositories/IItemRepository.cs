namespace Item.Infrastructure.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Domain.Models.Item>> GetItemsAsync();
        Domain.Models.Item GetItem(int id);
        Task<bool> SaveitemAsync(Domain.Models.Item item);
        Task<bool> DeleteItemAsync(int id);
        Task<bool> UpdateItemAsync(Domain.Models.Item item);
    }
}
