
using RabbitMQ.Client;
using Serilog;

namespace rabbitMQSend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            logger.Information("Envio de mensagens usando RabbitMQ");
            if (args.Length < 2)
            {
                logger.Error($"Informe ao menos 2 parâmetros  \n O segundo deve ser a Fila/Queue que vai receber as mensagens \n O Terceiro deve ser as mensagens que serão enviadas");
                return;
            }

            string nameQueue = args[0];
            logger.Information($"Queue: {nameQueue}");
            try
            {
                var factory = new ConnectionFactory() { Uri = new Uri("amqp://guest:guest@localhost:5672") };
                using var connection = factory.CreateConnection();
                using var channel = connection.CreateModel();
                channel.QueueDeclare(queue: nameQueue,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);
                for (int i = 1; i < args.Length; i++)
                {
                    channel.BasicPublish(exchange: string.Empty,
                                         routingKey: nameQueue,
                                         basicProperties: null,
                                         body: System.Text.Encoding.UTF8.GetBytes(args[i]));
                    logger.Information($"Mensagem enviada: {args[i]}");
                }
                logger.Information("Fim do envio das mensagens");
                System.Console.WriteLine("Aperte enter para sair");
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {

                logger.Error($"Erro ao criar conexão com o RabbitMQ: {ex.Message}");
            }
        }
    }
}