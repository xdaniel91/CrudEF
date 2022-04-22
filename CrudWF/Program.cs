using CrudWF.Database;
using CrudWF.Interface;
using CrudWF.Repositories;
using CrudWF.Services;
using Microsoft.Extensions.DependencyInjection;

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


            /*                               inicialização padrão
             * // To customize application configuration such as set high DPI settings or default font,
             // see https://aka.ms/applicationconfiguration.
             ApplicationConfiguration.Initialize();
             Application.Run(new frm_Main()); 
            */

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.ConfigureServices();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frm = serviceProvider.GetRequiredService<frm_Main>();
                Application.Run(frm);
            }
           
        }

        private static void ConfigureServices(this ServiceCollection services)
        {
            //database
            services.AddScoped<IUnityOfWork, UnityOfWork>();
            //person
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            //product
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<DataContext>();
            //frm
            services.AddScoped<frm_Main>();
            

        }
    }
}