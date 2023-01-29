using AcuConvert.Acumatica;
using AcuConvert.Core;
using AcuConvert.Core.Interfaces;
using AcuConvert.Core.Workers;
using AcuConvert.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AcuConvert;

static class Program
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
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }
    
    public static IServiceProvider ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
                   .ConfigureServices((context, services)=>
                    {
                        services.AddTransient<RecordReconciliator>();
                        services.AddTransient<ISyncWorker,SyncWorker>();
                        services.AddTransient<SyncConnectionBuilder>();
                        services.AddTransient<ISyncRepository,Repository>();
                        services.AddTransient<IAcumaticaConnector,AcumaticaConnector>();
                        services.AddTransient<ILegacyConnector,Sage500.Sage500>();
                        
                        services.AddTransient<Form1>();
                    });
    }
}