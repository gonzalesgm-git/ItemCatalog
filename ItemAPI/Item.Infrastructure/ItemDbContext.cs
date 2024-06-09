using Microsoft.EntityFrameworkCore;

namespace Item.Infrastructure
{
    public class ItemDbContext: DbContext
    {
        public ItemDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Domain.Models.Item> Items { get; set; }
    }
}
