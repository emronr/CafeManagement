using CafeManagement.Domain.Context;
using CafeManagement.Domain.Repositories.Base;
using CafeManagement.Domain.Repositories.Cafe;
using CafeManagement.Domain.Repositories.Menu;
using CafeManagement.Domain.Repositories.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CafeManagement.Domain.Extensions;

public static class ServiceRegistration
{
    public static void AddDomainRegistrations(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CafeManagementContext>(options
            => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        
        services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        services.AddScoped<ITableRepository, TableRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}