using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MKBezbednost_Members
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

            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            var DbPath = Path.GetFullPath("./mkb.db");

            builder.Services.AddDbContext<MKBDbContext>(options => options.UseSqlite($"Data Source={DbPath}"));

            builder.Services.AddScoped<IMKBDbContext, MKBDbContext>();

            using IHost host = builder.Build();

            Application.Run(new MainForm());
        }
    }
}