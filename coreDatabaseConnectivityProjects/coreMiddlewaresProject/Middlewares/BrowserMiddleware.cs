using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace coreMiddlewaresProject.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class BrowserMiddleware
    {
        private readonly RequestDelegate _next;

        public BrowserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Debug.WriteLine("User Agent : " + httpContext.Request.Headers["User-Agent"].ToString());
            Debug.WriteLine("IP : " + httpContext.Connection.RemoteIpAddress.ToString());
            Debug.WriteLine("Url : " + httpContext.Request.Path);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class BrowserMiddlewareExtensions
    {
        public static IApplicationBuilder UseBrowserMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<BrowserMiddleware>();
        }
    }
}
