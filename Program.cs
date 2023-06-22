using KLMAssignment.Common;
using KLMAssignment.DAL;
using KLMAssignment.DBContext;
using KLMAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace KLMAssignment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Form1());
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<KLMDbContext>(options => options.UseSqlServer
            (ConfigurationManager.ConnectionStrings.ToString()));
            services.AddTransient<Form1>();
            services.AddTransient<IDALBinding,DALBinding>();
        }
    }
}