using CafeManagement.Domain.Context;
using CafeManagement.Domain.Repositories.Base;
using CafeManagement.Domain.Repositories.Cafe;
using CafeManagement.Domain.Repositories.Menu;
using CafeManagement.Domain.Repositories.Order;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CafeManagement.Domain.Extensions;

public static class ServiceRegistration
{
    public static void AddDomainRegistrationsForDesktop(this IServiceCollection services)
    {
        services.AddTransient<CafeManagementContext>();
        //services.AddDbContext<CafeManagementContext>(options
        //    => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        services.AddScoped<ITableRepository, TableRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
    }
    
    public static void AddDomainRegistrationsForWebApp(this IServiceCollection services)
    {
        services.AddSingleton<CafeManagementContext>();
        //services.AddDbContext<CafeManagementContext>(options
        //    => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        services.AddScoped<ITableRepository, TableRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}