using ClassLibraryRabbit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.ObjectPool;
using RabbitMQ.Client;

namespace FakeEquifax;

public static class RabbitServiceCollectionExtensions  
{  
    public static IServiceCollection AddRabbit(this IServiceCollection services, IConfiguration configuration)  
    {  
        var rabbitConfig = configuration.GetSection("rabbit");  
        services.Configure<RabbitOptions>(rabbitConfig);  
  
        services.AddSingleton<ObjectPoolProvider, DefaultObjectPoolProvider>();  
        services.AddSingleton<IPooledObjectPolicy<IModel>, RabbitModelPooledObjectPolicy>();  
  
        services.AddSingleton<IRabbitManager, RabbitManager>();  
  
        return services;  
    }  
}  