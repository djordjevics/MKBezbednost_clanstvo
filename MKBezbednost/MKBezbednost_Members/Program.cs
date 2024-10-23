using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MKBezbednost_Members.Views;
using System.IO;

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
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            var DbPath = Path.GetFullPath("./mkb.db");

            builder.Services.AddDbContext<MKBDbContext>(options => options.UseSqlite($"Data Source={DbPath}"));

            builder.Services.AddScoped<IMKBDbContext, MKBDbContext>();

            using IHost host = builder.Build();

            MainWindow mainWindow = new();
            mainWindow.ShowDialog();
        }
    }
}