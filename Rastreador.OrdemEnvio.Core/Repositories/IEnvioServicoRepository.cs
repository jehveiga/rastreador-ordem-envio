using Rastreador.OrdemEnvio.Core.Entities;

namespace Rastreador.OrdemEnvio.Core.Repositories
{
    public interface IEnvioServicoRepository
    {
        Task<List<EnvioService>> GetAllAsync();
    }
}
