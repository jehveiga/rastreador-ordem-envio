using Rastreador.OrdemEnvio.Core.Entities;
using Rastreador.OrdemEnvio.Core.Repositories;

namespace Rastreador.OrdemEnvio.Infrastructure.Persistence.Repositories
{
    public class PedidoEnvioRepository : IPedidoEnvioRepository
    {
        public PedidoEnvioRepository(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public async Task AddAsync(PedidoEnvio entity) =>
            await _context.PedidoEnvios.AddAsync(entity);


        public async Task<PedidoEnvio?> GetByCodeAsync(string code) =>
            await _context.PedidoEnvios.FindAsync(code);
    }
}
