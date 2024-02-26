using MessageBrokerConsumer.Configurations;
using MessageBrokerConsumer.DTOs;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

string FILE_NAME = @"C:\Users\namiqrasullu\Desktop\testbranch\MessageBrokerAspApp\MessageBrokerConsumer\config.json";
var builder = new ConfigurationBuilder().AddJsonFile(FILE_NAME).Build();

var rabbitMQConfig = new RabbitMQConfiguration();
builder.Bind("RabbitMQ", rabbitMQConfig);

var factory = new ConnectionFactory
{
    HostName = rabbitMQConfig.HostName,
    UserName = rabbitMQConfig.UserName,
    Password = rabbitMQConfig.Password,
    Port = rabbitMQConfig.Port,
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: rabbitMQConfig.QueueName,
                     exclusive: false,
                     durable: false,
                     autoDelete: false,
                     arguments: null);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    var testDto = JsonSerializer.Deserialize<TestDto>(message);
    Console.WriteLine($"{testDto!.Name} {testDto!.Age}");
};

channel.BasicConsume(queue: rabbitMQConfig.QueueName,
                    autoAck: true,
                    consumer: consumer);
Console.WriteLine("Press [enter] to exit");
Console.ReadLine();
