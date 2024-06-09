using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ItemDbContext>((sp, optionsBuilder) =>
            {
                optionsBuilder.UseSqlServer(connectionString, options =>
                {
                    options.EnableRetryOnFailure(3);
                });
            });

            return services;
        }
    }
}
