using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyMiddleWebServer.Middlewares
{
    public delegate void HttpHandler(HttpListenerContext context);
    public interface IMiddleware
    {
        HttpHandler? Next { get; set; }

        void Handle(HttpListenerContext context);
    }
}
