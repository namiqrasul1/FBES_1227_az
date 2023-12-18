using MyMiddleWebServer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyMiddleWebServer.Middlewares
{
    public class MvcMiddleware : IMiddleware
    {
        public HttpHandler? Next { get; set; }

        public void Handle(HttpListenerContext context)
        {
            string? url = context.Request.RawUrl;
            if (!string.IsNullOrEmpty(url))
            {
                var sections = url.Split('/', StringSplitOptions.RemoveEmptyEntries);
                var controllerName = $"MyMiddleWebServer.Controllers.{sections[0]}Controller";
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type? type = assembly.GetType(controllerName);
                if (type is not null)
                {
                    Controller? controllerObj = Activator.CreateInstance(type) as Controller;
                    if(controllerObj is not null)
                    {
                        string actionName = sections[1];
                        controllerObj.Context = context;
                        MethodInfo? methodInfo = type.GetMethod(actionName);
                        methodInfo?.Invoke(controllerObj, null);
                    }   
                }

            }
        }
    }
}
