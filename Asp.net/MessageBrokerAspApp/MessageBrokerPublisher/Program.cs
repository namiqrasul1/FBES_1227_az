using MessageBrokerPublisher.Configurations;
using MessageBrokerPublisher.Services;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var section = builder.Configuration.GetSection("RabbitMQ");
var rabbitMQConfig = new RabbitMQConfiguration();
section.Bind(rabbitMQConfig);
builder.Services.AddSingleton(rabbitMQConfig);

builder.Services.AddSingleton<IConnectionFactory, ConnectionFactory>(sp =>
{
    var factory = new ConnectionFactory
    {   
        HostName = rabbitMQConfig.HostName,
        UserName = rabbitMQConfig.UserName,
        Password = rabbitMQConfig.Password,
        Port = rabbitMQConfig.Port,
    };
    return factory;
});

builder.Services.AddSingleton<IRabbitMQService, RabbitMQService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
