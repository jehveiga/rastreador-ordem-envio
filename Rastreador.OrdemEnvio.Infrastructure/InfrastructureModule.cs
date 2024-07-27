using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rastreador.OrdemEnvio.Core.Repositories;
using Rastreador.OrdemEnvio.Infrastructure.Persistence;
using Rastreador.OrdemEnvio.Infrastructure.Persistence.Repositories;

namespace Rastreador.OrdemEnvio.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories()
                    .AddPersistence(configuration);

            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase(connectionString));

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPedidoEnvioRepository, PedidoEnvioRepository>();
            services.AddScoped<IEnvioServicoRepository, EnvioServicoRepository>();

            return services;
        }
    }
}
