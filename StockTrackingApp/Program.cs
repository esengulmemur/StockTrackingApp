using EntityFrameworkCore.EntityFrameworkCore.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockTrackingApp.Customers;
using StockTrackingApp.Products;

namespace StockTrackingApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<formSales>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton(typeof(IStockTrackingRepository<>), typeof(StockTrackingRepository<>));
                    services.AddTransient<formSales>();
                    services.AddTransient<frmAddCustomer>();
                    services.AddTransient<FrmListCustomer>();
                    services.AddTransient<FormAddProduct>();
                });
        }
    }
}