namespace ClassLibraryRabbit;

public interface IRabbitManager
{
    void Publicar<T>(T message, string exchangeName, string exchangeType, string routeKey)
        where T : class;

    /*void Consumir<T>(string queueName)   
        where T : class;  */
}  