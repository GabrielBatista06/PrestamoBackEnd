using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrestamoGJ.Application.Core.Business;
using PrestamoGJ.Application.Core.Interfaces.BusinessServices;

namespace PrestamoGJ.WepApi.Configuration.Extensions
{
    public static class BusinessServicesExtension
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ILoginService, LoginServices>();
            return services;
        }
    }
}
