using Microsoft.EntityFrameworkCore;
using Rastreador.OrdemEnvio.Core.Entities;
using Rastreador.OrdemEnvio.Core.Repositories;

namespace Rastreador.OrdemEnvio.Infrastructure.Persistence.Repositories
{
    public class EnvioServicoRepository : IEnvioServicoRepository
    {
        public EnvioServicoRepository(AppDbContext context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;

        public async Task<List<EnvioService>> GetAllAsync() =>
            await _context.EnvioServices.ToListAsync();
    }
}
