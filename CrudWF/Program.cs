using CrudWF.Interface;
using CrudWF.Repositories;
using CrudWF.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CrudWF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
              .ConfigureServices((hostContext, services) =>
              {
                  services.AddSingleton<frm_Main>();
                  services.AddLogging(configure => configure.AddConsole());
                  services.AddScoped<IPersonRepository, PersonRepository>();
                  services.AddScoped<IUnityOfWork, UnityOfWork>();
                  services.AddScoped<IPersonService, PersonService>();

              });

            /* https://www.thecodebuzz.com/dependency-injection-net-core-windows-form-generic-hostbuilder/ */
            var host = builder.Build();

            /* // To customize application configuration such as set high DPI settings or default font,
             // see https://aka.ms/applicationconfiguration.
             ApplicationConfiguration.Initialize();
             Application.Run(new frm_Main()); */
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IUnityOfWork, UnityOfWork>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddSingleton<frm_Main>();
        }
    }
}