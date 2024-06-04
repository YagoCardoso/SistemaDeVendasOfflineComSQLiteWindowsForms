using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pdv.Application;
using Pdv.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimdexxSystem
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            //Application.Run(new Carregamento());
            Application.Run(ServiceProvider.GetRequiredService<Carregamento>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IClienteService, ClienteService>();
                    services.AddTransient<Clientes>();
                    services.AddTransient<Carregamento>();
                });
        }
    }
}
