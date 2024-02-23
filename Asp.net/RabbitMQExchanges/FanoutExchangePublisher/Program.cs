using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory
{
    HostName = "localhost",
};
Console.ReadKey();
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("workqueue", type: ExchangeType.Fanout);

for (int i = 0; i < 50; i++)
{
    var bytes = Encoding.UTF8.GetBytes($"message - {i}");
    IBasicProperties properties = channel.CreateBasicProperties();
    properties.Persistent = true;
    channel.BasicPublish(exchange: "workqueue", routingKey: "", basicProperties: properties, body: bytes);
}