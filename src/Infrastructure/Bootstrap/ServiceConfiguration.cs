using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Bootstrap.MediatR;

namespace Infrastructure.Bootstrap
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection configureServices(this IServiceCollection services)
        {
            services.ConfigureMediatrServices();

            return services;
        }
    }
}
