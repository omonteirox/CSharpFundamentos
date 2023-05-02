
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace rabbitMQReceive
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly int _intervaloMensagemWorkerAtivo;
        private readonly ExecuteParams _executeParams;

        public Worker(ILogger<Worker> logger,
            IConfiguration configuration,
            ExecuteParams executeParams)
        {
            logger.LogInformation(
                $"Queue = {executeParams.Queue}");
            logger.LogInformation(
                $"ConnectionString = {executeParams.ConnectionString}");
            _logger = logger;
            _intervaloMensagemWorkerAtivo =
                Convert.ToInt32(configuration["IntervaloMensagemWorkerAtivo"]);
            _executeParams = executeParams;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Aguardando mensagens...");

            var factory = new ConnectionFactory()
            {
                Uri = new Uri(_executeParams.ConnectionString)
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: _executeParams.Queue,
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    _logger.LogInformation(
                $"[Nova mensagem | {DateTime.Now:yyyy-MM-dd HH:mm:ss}] " +
                Encoding.UTF8.GetString(ea.Body.ToArray()));
                };
            channel.BasicConsume(queue: _executeParams.Queue,
                autoAck: true,
                consumer: consumer);

        }


    }
}