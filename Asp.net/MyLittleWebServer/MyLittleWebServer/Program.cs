using System.Net;

namespace MyLittleWebServer;

public class WebHost
{
    int _port;
    HttpListener _listener;

    public WebHost(int port)
    {
        _port = port;
        _listener = new HttpListener();
    }

    public void Run()
    {
        _listener.Prefixes.Add($"http://localhost:{_port}/");
        _listener.Start();

        Console.WriteLine($"Http server started on {_port}");

        while (true)
        {
            var context = _listener.GetContext();
            Task.Run(() =>
            {
                HandleRequest(context);
            });
        }
    }

    private void HandleRequest(HttpListenerContext context)
    {
        var str = context.Request.RawUrl;
        var path = $@"C:\Users\namiqrasullu\source\repos\MyLittleWebServer\MyLittleWebServer\Views\{str!.Split("/").Last()}";
        var response = context.Response;
        StreamWriter sw = new(response.OutputStream);
        try
        {
            //response.ContentType = "application/json";
            var src = File.ReadAllText(path);
            sw.Write(src);
        }
        catch (Exception)
        {
            sw.Write(File.ReadAllText(@"C:\Users\namiqrasullu\source\repos\MyLittleWebServer\MyLittleWebServer\Views\error.html"));
        }
        finally
        {
            sw.Close();
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        new WebHost(27001).Run();
    }
}