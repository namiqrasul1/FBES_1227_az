using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyMiddleWebServer.Middlewares
{
    public class StaticFilesMiddleware : IMiddleware
    {
        public HttpHandler? Next { get; set; }

        public void Handle(HttpListenerContext context)
        {
            if(Path.HasExtension(context.Request.RawUrl))
            {
                try
                {
                    string filename = context.Request.RawUrl.Substring(1);
                    string path = $@"C:\Users\namiqrasullu\source\repos\MyMiddleWebServer\MyMiddleWebServer\wwwroot\{filename}";
                    var bytes = File.ReadAllBytes(path);
                    if (Path.GetExtension(path) == "html" || Path.GetExtension(path) == "htm")
                        context.Response.AddHeader("Content-type", "text/html");
                    else if (Path.GetExtension(path) == "webp")
                        context.Response.AddHeader("Content-type", "image/webp");
                    else if (Path.GetExtension(path) == "png")
                        context.Response.AddHeader("Content-type", "image/png");
                    else if (Path.GetExtension(path) == "jpg")
                        context.Response.AddHeader("Content-type", "image/jpg");
                    context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                }
                catch (Exception)
                {
                    context.Response.StatusCode = 404;
                    context.Response.StatusDescription = "file not found";
                }
            }
            else
                Next?.Invoke(context);
            context.Response.Close();
        }
    }
}
