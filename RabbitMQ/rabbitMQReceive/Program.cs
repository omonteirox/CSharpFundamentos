using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Serilog;
// docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.11-management
namespace rabbitMQReceive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            logger.Information("*** Testando o consumo de mensagens com RabbitMQ + Filas ***");
            logger.Information("Você está na fila: " + args[0]);
            if (args.Length != 1)
            {
                logger.Error("Informe o parametro da fila/Queue que vai ser utilizada no consumo das mensagems:");
                return;
            }

            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: args[0],
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            logger.Information("Aguardando mensagens...");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                logger.Information($"[Nova mensagem | {DateTime.Now:yyyy-MM-dd HH:mm:ss}] " + Encoding.UTF8.GetString(ea.Body.ToArray()));

            };
            channel.BasicConsume(queue: args[0],
                                 autoAck: true,
                                 consumer: consumer);

            logger.Information(" aperte [enter] para sair.");
            Console.ReadLine();
        }
    }
}