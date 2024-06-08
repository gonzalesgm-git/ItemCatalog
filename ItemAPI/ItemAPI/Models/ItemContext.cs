using Microsoft.EntityFrameworkCore;

namespace ItemAPI.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
