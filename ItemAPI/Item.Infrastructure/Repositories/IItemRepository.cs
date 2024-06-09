using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Infrastructure.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Domain.Models.Item>> GetItemsAsync();
        Task<Domain.Models.Item> GetItemAsync(int id);
        Task<Domain.Models.Item> SaveitemAsync(Domain.Models.Item item);
        void DeleteItem(int id);
        void UpdateItem(Domain.Models.Item item);
    }
}
