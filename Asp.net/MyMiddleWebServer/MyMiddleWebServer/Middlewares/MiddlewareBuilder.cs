﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMiddleWebServer.Middlewares
{
    public class MiddlewareBuilder
    {
        private Stack<Type> _middlewares = new();

        public void Use<T>() where T : IMiddleware
        {
            _middlewares.Push(typeof(T));
        }

        public HttpHandler Build()
        {
            HttpHandler handler = context => context.Response.Close();
            while (_middlewares.Count > 0)
            {
                Type type = _middlewares.Pop();
                IMiddleware? middleware = Activator.CreateInstance(type) as IMiddleware;
                middleware!.Next = handler;
                handler = middleware.Handle;
            }
            return handler;
        }
    }
}
