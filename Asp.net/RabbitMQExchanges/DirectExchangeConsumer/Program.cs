using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory
{
    HostName = "localhost",
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare(exchange: "directexchange", type: ExchangeType.Direct);

var key = int.Parse(Console.ReadLine()!);

var queueName = channel.QueueDeclare().QueueName;

if (key == 1)
    channel.QueueBind(queue: queueName, exchange: "directexchange", routingKey: "tekmesajlar");
else
    channel.QueueBind(queue: queueName, exchange: "directexchange", routingKey: "cutmesajlar");

channel.BasicQos(0, 1, false);

var consumer = new EventingBasicConsumer(channel);

channel.BasicConsume(queueName, false, consumer);

consumer.Received += (sender, args) =>
{
    Thread.Sleep(300);
    Console.WriteLine(Encoding.UTF8.GetString(args.Body.ToArray()));
    channel.BasicAck(args.DeliveryTag, false);
};

Console.ReadKey();
