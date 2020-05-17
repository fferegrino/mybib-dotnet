using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyBib.WebApi.Middleware
{
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;

        public SampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //

            await _next(context);
        }
    }
}