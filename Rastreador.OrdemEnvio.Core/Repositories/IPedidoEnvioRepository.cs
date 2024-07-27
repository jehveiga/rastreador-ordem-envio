using Rastreador.OrdemEnvio.Core.Entities;

namespace Rastreador.OrdemEnvio.Core.Repositories
{
    public interface IPedidoEnvioRepository
    {
        Task<PedidoEnvio?> GetByCodeAsync(string code);
        Task AddAsync(PedidoEnvio entity);
    }
}
