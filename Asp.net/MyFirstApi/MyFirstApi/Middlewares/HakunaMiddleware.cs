using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyFirstApi.Middlewares
{
    public class HakunaMiddleware
    {
        RequestDelegate _next;
        public HakunaMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            System.Console.WriteLine("Hakuna Matata");
            await _next(context);
            System.Console.WriteLine("42");
        }
    }
}
