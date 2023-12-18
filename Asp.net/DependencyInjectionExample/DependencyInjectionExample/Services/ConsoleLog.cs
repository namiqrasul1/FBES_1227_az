namespace DependencyInjectionExample.Services
{
    public class ConsoleLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine($"ConsoleLog: {message}");
        }
    }
}
