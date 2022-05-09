using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using FakeEquifax.Modelos;
using System.Text.Json;

namespace WorkerServiceScoring
{
    public class Worker : BackgroundService
    {
        
        private readonly ILogger<Worker> _logger;
        //private IConfiguration _configuration;
        private IConnectionFactory _factoriaRabbitConexion;
        private IConnection _conexionRabbit;
        private IModel _channel;


        public Worker(ILogger<Worker> logger) //, IConfiguration configuration)
        {
            _logger = logger;
            //_configuration = configuration;
            
            InitRabbitMQ();
        }

        private void InitRabbitMQ()
        {
            _factoriaRabbitConexion = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
                VirtualHost = "/",
                Port = AmqpTcpEndpoint.UseDefaultPort
            };

            _conexionRabbit = _factoriaRabbitConexion.CreateConnection();
            _channel = _conexionRabbit.CreateModel();

            _conexionRabbit.ConnectionShutdown += RabbitMQ_ConnectionShutdown;
        }

        private void RabbitMQ_ConnectionShutdown(object? sender, ShutdownEventArgs e)
        {
            
        }



        protected override async Task<Task> ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += OnConsumerOnReceived;
            consumer.Shutdown += OnConsumerShutdown;
            consumer.Registered += OnConsumerRegistered;
            consumer.Unregistered += OnConsumerUnregistered;
            consumer.ConsumerCancelled += OnConsumerCancelled;

            _channel.BasicConsume(queue: "dev.scoring.queue", autoAck: false, consumer: consumer);

            return Task.CompletedTask;
          
        }

        public override void Dispose()
        {
            _channel.Close();
            _conexionRabbit.Close();
            base.Dispose();
        }

        private bool ManejadorMensajes(string content)
        {
            Console.WriteLine(content);
            _logger.LogInformation($"consumer received {content}");
            
            //Persona MensajePersonaScoring = JsonSerializer.Deserialize<Persona>(content);
            //TODO enviar a la api el mensaje minimo equifax
           

            return true;
        }


        private void OnConsumerOnReceived(object? sender, BasicDeliverEventArgs e)
        {
            var body = e.Body;
            string content = System.Text.Encoding.UTF8.GetString(e.Body.ToArray());


            ManejadorMensajes(content);

            var resultado = true;

            if (resultado)
            {
                _channel.BasicAck(e.DeliveryTag, false);

            } 
            else
            {
                //ver que hacemos con los mensajes de error/ o qu eno se manejen etc..
                //mandar cola errores
               // _channel.BasicAck(e.DeliveryTag, true);
            }
        }

        private void OnConsumerShutdown(object? sender, ShutdownEventArgs e)
        {
            
        }

        private void OnConsumerRegistered(object? sender, ConsumerEventArgs e)
        {

        }


        private void OnConsumerUnregistered(object? sender, ConsumerEventArgs e)
        {

        }
        private void OnConsumerCancelled(object? sender, ConsumerEventArgs e)
        {

        }



    }
}