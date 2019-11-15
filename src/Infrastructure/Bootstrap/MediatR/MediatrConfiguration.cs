using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Bootstrap.MediatR
{
    public static class MediatorConfiguration
    {
        public static IServiceCollection ConfigureMediatrServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof (Application.Mediators.UserRequestHandler));

            return services;
        }
    }
}