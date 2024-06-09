using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
