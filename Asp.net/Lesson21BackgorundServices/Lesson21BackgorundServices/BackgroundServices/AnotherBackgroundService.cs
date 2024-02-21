using System.ComponentModel;

namespace Lesson21BackgorundServices.BackgroundServices
{
    public class AnotherBackgroundService : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("AnotherBackgroundService working");
            return Task.CompletedTask;
        }
    }
}
