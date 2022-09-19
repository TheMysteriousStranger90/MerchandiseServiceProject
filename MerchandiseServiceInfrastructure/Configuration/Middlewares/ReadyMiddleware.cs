using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MerchandiseServiceInfrastructure.Configuration.Middlewares
{
    public class ReadyMiddleware
    {
        public ReadyMiddleware(RequestDelegate next)
        {
            
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync($"{StatusCodes.Status200OK.ToString()} Ok");
        }
    }
}