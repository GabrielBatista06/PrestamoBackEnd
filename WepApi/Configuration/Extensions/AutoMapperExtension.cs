using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PrestamoGJ.Application.Core.Configuration.MapperProfiles;

namespace PrestamoGJ.WepApi.Configuration.Extensions
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            var mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}
