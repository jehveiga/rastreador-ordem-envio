using Microsoft.Extensions.DependencyInjection;
using Rastreador.OrdemEnvio.Application.Services;

namespace Rastreador.OrdemEnvio.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddApplicationServices();

            return services;
        }

        private static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPedidoEnvioService, PedidoEnvioService>();
            services.AddScoped<IEnvioServiceService, EnvioServiceService>();

            return services;
        }
    }
}
