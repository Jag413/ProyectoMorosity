using Serilog;
using WorkerServiceScoring;

IConfiguration config = new ConfigurationBuilder()
    .AddUserSecrets("dotnet-WorkerServiceScoring-68B35912-1317-40D6-BDC1-775E72411C78")
    .Build();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .ConfigureLogging(loggerBuilder => 
    {
       // string entorno = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT").ToString();
        var miConfiguracion = new ConfigurationBuilder()
            //.AddUserSecrets("dotnet-WorkerServiceScoring-68B35912-1317-40D6-BDC1-775E72411C78")
            .SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json") // nos la podriamos ahorrar
            //development -> appsettingsDevelopment.json y en Production appsettingsProduction.json
            //.AddJsonFile($"appsettings.{entorno}.json")
            .Build();

        var logeador = new LoggerConfiguration()
        .ReadFrom.Configuration(miConfiguracion)
        .CreateLogger();

        loggerBuilder.AddSerilog(logeador, dispose : true);
    })
    .Build();

await host.RunAsync();
