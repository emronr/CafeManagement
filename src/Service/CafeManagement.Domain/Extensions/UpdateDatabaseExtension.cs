using CafeManagement.Domain.Context;
using CafeManagement.Domain.Seed;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Extensions
{
    public static class UpdateDatabaseExtension
    {
        public static void SeedAndMigrate(IServiceProvider serviceProvider)
        {

            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                try
                {
                    var context = serviceScope.ServiceProvider.GetService<CafeManagementContext>();

                    context.Database.Migrate();

                    Seeder.Seed(context);
                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
