using Serilog;
using TestRedisSerilog.Configs;
using TestRedisSerilog.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddLogging();

//Log.Logger = new LoggerConfiguration()
//    .MinimumLevel.Debug()
//    .WriteTo.Console()
//    .CreateLogger();

var outputTemplate = "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console(outputTemplate: outputTemplate)
    .WriteTo.File(
            path: "C:\\Users\\namiqrasullu\\Desktop\\FBES_1227_az\\Asp.net\\TestRedisSerilog\\TestRedisSerilog\\logs\\log.txt",
            outputTemplate: outputTemplate)
    .CreateLogger();

builder.Services.AddSerilog();

var redisConfig = new RedisConfig(string.Empty, string.Empty);
builder.Configuration.GetSection("RedisConfig").Bind(redisConfig);

builder.Services.AddStackExchangeRedisCache(sa =>
{
    sa.InstanceName = redisConfig.InstanceName;
    sa.Configuration = redisConfig.Configuration;
});

builder.Services.AddScoped<ICacheService, CacheService>();

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
