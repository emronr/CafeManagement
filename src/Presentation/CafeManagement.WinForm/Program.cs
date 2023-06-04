using CafeManagement.Business.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CafeManagement.WinForm
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();

            ServiceProvider = host.Services;
            ServiceProvider.UpdateDatabase();
            Application.Run(ServiceProvider.GetRequiredService<MainMenu>());

        }
        static IHostBuilder CreateHostBuilder()
        {

            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:false, reloadOnChange: true).Build();

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(builder =>
                {
                    builder.Sources.Clear();
                    builder.AddConfiguration(Configuration);
                })
                 .ConfigureServices((context, services) => {
                     ConfigureServices(services);
                 });

            return host;
        }
        static void ConfigureServices(IServiceCollection services)
        {
            services.AddBusinessRegistrationForDesktopApp();

            //forms
            services.AddTransient<MainMenu>();
            services.AddTransient<Menu>();
        }

    }
}