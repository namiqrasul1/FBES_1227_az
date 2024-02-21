namespace Lesson21BackgorundServices.BackgroundServices
{
    public class SomeBackgroundService : IHostedService, IDisposable
    {
        private Timer? _timer;
        private readonly ServiceProvider _provider;

        public SomeBackgroundService(ServiceProvider provider)
        {
            _provider = provider;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Backgroud Service started");
            _timer = new Timer(Run, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            return Task.CompletedTask;
        }

        private void Run(object? state)
        {
            Console.WriteLine("Some bs");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Backgroud Service stopped");
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
            _timer = null;
        }
    }
}
