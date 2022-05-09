using System.Text;
using Microsoft.Extensions.ObjectPool;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ClassLibraryRabbit;

public class RabbitManager : IRabbitManager  
{  
    private readonly DefaultObjectPool<IModel> _objectPool;  
  
    public RabbitManager(IPooledObjectPolicy<IModel> objectPolicy)  
    {  
        _objectPool = new DefaultObjectPool<IModel>(objectPolicy, Environment.ProcessorCount * 2);  
    }  
  
    public void Publicar<T>(T message, string exchangeName, string exchangeType, string routeKey)   
        where T : class  
    {  
        if (message == null)  
            return;  
  
        var channel = _objectPool.Get();  
  
        try  
        {  
            channel.ConfirmSelect();
            
            channel.ExchangeDeclare(exchangeName, exchangeType, true, false, null);  
  
            var sendBytes = Encoding.UTF8.GetBytes(System.Text.Json.JsonSerializer.Serialize(message));  
  
            var properties = channel.CreateBasicProperties();  
            properties.Persistent = true;  
  
            channel.BasicPublish(exchangeName, routeKey, properties, sendBytes);  
        }  
        catch (Exception ex)  
        {  
            throw ex;  
        }  
        finally  
        {  
            _objectPool.Return(channel);                  
        }  
    }

    public void Consumir<T>(string exchangeName) where T : class
    {
        var Channel = _objectPool.Get();

        try
        {
            Channel.QueueDeclare(queue: "exchange.scoring.dev", durable: true, exclusive: false, autoDelete: false, arguments: null);
            var Consumer = new EventingBasicConsumer(Channel);

            Consumer.Received += (model, ea) =>
            {
                var Message = Encoding.UTF8.GetString(ea.Body.ToArray());
                Console.WriteLine(Message);
                Thread.Sleep(1000);
                Console.WriteLine("Done");
            };
            Channel.BasicConsume(queue: "exchange.scoring.dev", autoAck: true, consumer: Consumer);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally 
        { 
            _objectPool.Return(Channel); 
        }
    }


    
}  