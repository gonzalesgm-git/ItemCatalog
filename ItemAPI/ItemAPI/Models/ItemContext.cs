using Microsoft.EntityFrameworkCore;
using Item.Domain.Models;

namespace ItemAPI.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item.Domain.Models.Item> Items { get; set; }
    }
}
