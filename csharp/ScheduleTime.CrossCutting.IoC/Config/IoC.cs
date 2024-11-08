using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScheduleTime.Application.Handlers;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.Application.Services;
using ScheduleTime.Application.UseCases;
using ScheduleTime.CrossCutting.ProfileMapper;
using ScheduleTime.DataBase.Context;
using ScheduleTime.DataBase.Interfaces;
using ScheduleTime.DataBase.Repositories;

namespace ScheduleTime.CrossCutting.IoC.Config
{
    public static class IoC
    {
        public static IServiceCollection ContainerIoC(this IServiceCollection services, IConfiguration configuration)
        {
            services.DependencyInjection(configuration);
            return services;
        }

        private static IServiceCollection DependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            #region Application
            services.AddScoped<IBeautySalonHandler, BeautySalonHandler>();
            services.AddScoped<IBeautySalonUseCase, BeautySalonUseCase>();
            services.AddScoped<IBeautySalonService, BeautySalonService>();
            /*----------------------------------------------------------*/
            services.AddScoped<IBarberShopHandler, BarberShopHandler>();
            services.AddScoped<IBarberShopUseCase, BarberShopUseCase>();
            services.AddScoped<IBarberShopService, BarberShopService>();
            /*----------------------------------------------------------*/
            #endregion Application

            #region Infrastructure
            services.ConfigurationDataBaseRelational(configuration);
            /*----------------------------------------------------------*/
            services.AddScoped<IBarberShopRepository, BarberShopRepository>();
            services.AddScoped<IBeautySalonRepository, BeautySalonRepository>();
            #endregion Infrastructure

            #region Web
            #endregion Web

            #region Others
            services.ConfigurationAutoMapper();
            #endregion Others

            return services;
        }

        private static IServiceCollection ConfigurationDataBaseRelational(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("PostgreSql")));
            return services;
        }

        private static IServiceCollection ConfigurationAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new BeautySalonMapper());

            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
