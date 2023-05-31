using CafeManagement.Business.Mapping;
using CafeManagement.Business.Services.Management;
using CafeManagement.Business.Services.Menu;
using CafeManagement.Domain.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CafeManagement.Business.Extensions;

public static class ServiceRegistration
{
    public static void AddBusinessRegistrationForDesktopApp(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDomainRegistrations(configuration);
        
        services.AddAutoMapper(config => config.AddProfile(new MappingProfile()));

        services.AddTransient<IManagementService, ManagementService>();
        services.AddTransient<ICategoryService, CategoryService>();
        services.AddTransient<IProductService,ProductService >();
        
    }
}