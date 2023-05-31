using CafeManagement.Domain.Context;
using CafeManagement.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CafeManagement.Domain;

public static class ServiceRegistration
{
    public static void AddDomainRegistrations(this ServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CafeManagementContext>(options
            => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

    }
}