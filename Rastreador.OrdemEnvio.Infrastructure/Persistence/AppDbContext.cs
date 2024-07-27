using Microsoft.EntityFrameworkCore;
using Rastreador.OrdemEnvio.Core.Entities;

namespace Rastreador.OrdemEnvio.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<EnvioService> EnvioServices { get; set; }
        public DbSet<PedidoEnvio> PedidoEnvios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnvioService>().HasData(new EnvioService("Envio estadual", 3.75m, 12));
            modelBuilder.Entity<EnvioService>().HasData(new EnvioService("Envio internacional", 5.25m, 15));
            modelBuilder.Entity<EnvioService>().HasData(new EnvioService("Caixa tamanho P", 0, 5));

            base.OnModelCreating(modelBuilder);
        }
    }
}
