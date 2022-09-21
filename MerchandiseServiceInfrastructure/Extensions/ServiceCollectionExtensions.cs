using Microsoft.Extensions.DependencyInjection;
using MediatR;
using MerchandiseServiceInfrastructure.Handlers.MerchPackAggregate;

namespace MerchandiseServiceInfrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /*
        public static IServiceCollection AddInfrastructure(this IServiceCollection service)
        {
            service.AddMediatR(typeof(MerchPackRequestCommandHandler).Assembly);
            return service;
        }
        */
    }
}