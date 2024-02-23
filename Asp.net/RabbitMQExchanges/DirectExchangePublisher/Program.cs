using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory
{
    HostName = "localhost",
};
Console.ReadKey();
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare(exchange: "directexchange", type: ExchangeType.Direct);

for (int i = 0; i < 100; i++)
{
    var bytes = Encoding.UTF8.GetBytes($"message - {i}");
    IBasicProperties properties = channel.CreateBasicProperties();
    properties.Persistent = true;

    if (i % 2 == 0)
        channel.BasicPublish(exchange: "directexchange", "cutmesajlar", basicProperties: properties, body: bytes);
    else
        channel.BasicPublish(exchange: "directexchange", "tekmesajlar", basicProperties: properties, body: bytes);


}