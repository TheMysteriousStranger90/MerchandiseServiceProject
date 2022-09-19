using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MerchandiseServiceInfrastructure.Configuration.Middlewares
{
    public class LiveMiddleware
    {
        public LiveMiddleware(RequestDelegate next)
        {
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync($"{StatusCodes.Status200OK.ToString()} Ok");
        }
    }
}