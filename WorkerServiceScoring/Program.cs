using WorkerServiceScoring;

IConfiguration config = new ConfigurationBuilder()
    .AddUserSecrets("dotnet-WorkerServiceScoring-68B35912-1317-40D6-BDC1-775E72411C78")
    .Build();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
