using CafeManagement.Business.Extensions;

namespace CafeManagement.API.Extensions;

public static class ServiceRegistration
{
    public static void AddApiRegistration(this IServiceCollection services)
    {
        services.AddBusinessRegistrationForWebApp();

        services.AddControllers()
            .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}