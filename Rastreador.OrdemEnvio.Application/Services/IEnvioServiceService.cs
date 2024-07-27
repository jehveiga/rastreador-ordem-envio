using Rastreador.OrdemEnvio.Application.Dtos.ViewModels;

namespace Rastreador.OrdemEnvio.Application.Services
{
    public interface IEnvioServiceService
    {
        Task<List<EnvioServiceViewModel>> GetAll();
    }
}
