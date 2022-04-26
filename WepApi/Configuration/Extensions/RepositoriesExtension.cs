using Microsoft.Extensions.DependencyInjection;
using PrestamoGJ.Application.Core.Interfaces.Repositories;
using PrestamoGJ.Infrastructure.Repositories;

namespace PrestamoGJ.WepApi.Configuration.Extensions
{
    public static class RepositoriesExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ILoginRepository, CustomLoginRepository>();
            services.AddScoped<IUsuarioRepository, CustomUsuarioRepository>();
            return services;
        }
    }
}
