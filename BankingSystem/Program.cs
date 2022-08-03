using System;
using Utility;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Core.Implementation;
using Core.Interfaces;
using Data.Repositories;
using Data.Interfaces;
using Data;

namespace BankingSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            using(var service = services.BuildServiceProvider())
            {
                var begin = service.GetService<Welcome>();
                Application.Run(begin);
            }
        }

        public static void ConfigureServices(ServiceCollection services)
        {
            //UserControl services
            services.AddSingleton<IBankRepository, BankRepository>();
            services.AddScoped<IAccountRespository, AccountRespository>();
            services.AddScoped<IAccountServices, AccountServices>();
            services.AddScoped<ISESSIONS, SESSIONS>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IUserRespository, UserRespository>();
            services.AddScoped<IValidation, Validation>();
            services.AddSingleton<IProtocols, Protocols>();
            services.AddScoped<IWriteToFile, WriteToFile>();


            //================ classes that winform instance in the globals DI container
            services.AddScoped<Welcome>();
            services.AddScoped<Login>();
            services.AddScoped<Register>();
            services.AddScoped<deposit>();
            services.AddScoped<Withdrawal>();
            services.AddScoped<dashboard>();
            services.AddScoped<Transfer>();
            services.AddScoped<CreateAccount>();
            services.AddScoped<PrintStatement>();
        }
    }
}
