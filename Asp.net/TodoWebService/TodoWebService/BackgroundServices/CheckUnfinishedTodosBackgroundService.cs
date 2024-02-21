
using Microsoft.EntityFrameworkCore;
using TodoWebService.Data;

namespace TodoWebService.BackgroundServices
{
    public class CheckUnfinishedTodosBackgroundService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private Timer? _timer;

        public CheckUnfinishedTodosBackgroundService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {


            _timer = new Timer(Run, null, TimeSpan.Zero, TimeSpan.FromMinutes(5));

            return Task.CompletedTask;
        }

        private async void Run(object? state)
        {
            var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<TodoDbContext>();
            var todos = await dbContext.TodoItems.Include(t => t.User)
                .Where(todo => todo.Deadline.Date == DateTime.Now.AddDays(1).Date)
                .ToListAsync();

            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Text} {todo.User.UserName}");
            }

            // send mail
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Dispose();
            _timer = null;
            return Task.CompletedTask;
        }
    }
}
