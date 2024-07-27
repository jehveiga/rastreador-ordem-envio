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

            modelBuilder.Entity<PedidoEnvio>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.OwnsOne(e => e.EnderecoEntrega, endereco =>
                {
                    endereco.Property(e => e.Rua).IsRequired();
                    endereco.Property(e => e.Numero).IsRequired();
                    endereco.Property(e => e.Cep).IsRequired();
                    endereco.Property(e => e.Cidade).IsRequired();
                    endereco.Property(e => e.Estado).IsRequired();
                    endereco.Property(e => e.Pais).IsRequired();
                    endereco.Property(e => e.EmailContato).IsRequired();
                });
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
