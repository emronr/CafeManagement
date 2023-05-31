using CafeManagement.Domain.Context;
using CafeManagement.Domain.Seed;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CafeManagement.Domain.Extensions;

public static class UpdateDatabaseExtension
{
    public static void SeedToDB(this IApplicationBuilder app, bool useMigrate = true)
    {
        using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            try
            {
                var context = serviceScope.ServiceProvider.GetService<CafeManagementContext>();

                if (useMigrate)
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