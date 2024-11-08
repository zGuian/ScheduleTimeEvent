using Microsoft.Extensions.DependencyInjection;
using ScheduleTime.Application.Handlers;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.Application.Services;
using ScheduleTime.Application.UseCases;

namespace ScheduleTime.CrossCutting.IoC.Config
{
    public static class IoC
    {
        public static IServiceCollection ContainerDI(this IServiceCollection services)
        {
            services.DependencyInjection();
            return services;
        }

        private static IServiceCollection DependencyInjection(this IServiceCollection services)
        {
            #region Application
            services.AddScoped<IBeautySalonHandler, BeautySalonHandler>();
            services.AddScoped<IBeautySalonUseCase, BeautySalonUseCase>();
            services.AddScoped<IBeautySalonService, BeautySalonService>();
            /*----------------------------------------------------------*/
            services.AddScoped<IBarberShopHandler, BarberShopHandler>();
            services.AddScoped<IBarberShopUseCase,BarberShopUseCase>();
            services.AddScoped<IBarberShopService, BarberShopService>();
            /*----------------------------------------------------------*/
            #endregion Application

            #region Infrastructure
            #endregion Infrastructure

            #region Web

            #endregion Web
            return services;
        }
    }
}
