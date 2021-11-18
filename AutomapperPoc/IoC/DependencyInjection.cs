using System;
using AutoMapper.Configuration;
using AutomapperPoc.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AutomapperPoc.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddStuff(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IPersonServices, PersonServices>();

            return services;
        }
    }
}
