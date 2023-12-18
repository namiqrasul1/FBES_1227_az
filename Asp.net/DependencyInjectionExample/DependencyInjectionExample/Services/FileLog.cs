namespace DependencyInjectionExample.Services
{
    public class FileLog : ILog
    {
        public FileLog()
        {
            Console.WriteLine("FileLog()");
        }
        public void Log(string message)
        {
            Console.WriteLine($"File Log: {message}");
        }
    }
}
