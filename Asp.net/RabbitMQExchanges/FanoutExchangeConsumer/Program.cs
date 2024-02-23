using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory
{
    HostName = "localhost",
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("workqueue", type: ExchangeType.Fanout);

string queueName = channel.QueueDeclare().QueueName;

channel.QueueBind(queue: queueName, exchange: "workqueue", routingKey: "");

channel.BasicQos(prefetchSize: 0, prefetchCount: 1, false);

var consumer =new EventingBasicConsumer(channel);
channel.BasicConsume(queueName, false, consumer);

consumer.Received += (sender, eAgrs) =>
{
    Thread.Sleep(100);
    Console.WriteLine(Encoding.UTF8.GetString(eAgrs.Body.ToArray()));
    channel.BasicAck(eAgrs.DeliveryTag, false);
};

Console.ReadKey();

