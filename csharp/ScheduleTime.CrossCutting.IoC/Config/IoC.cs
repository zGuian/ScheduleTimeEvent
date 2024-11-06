using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace ScheduleTime.CrossCutting.IoC.Config
{
    public static class IoC
    {
        public static IServiceCollection AddDI(this IServiceCollection services)
        {
            services.ContainerDI();
            return services;
        }

        private static IServiceCollection ContainerDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
