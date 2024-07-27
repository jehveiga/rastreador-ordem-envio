using Rastreador.OrdemEnvio.Application.Dtos.ViewModels;
using Rastreador.OrdemEnvio.Core.Repositories;

namespace Rastreador.OrdemEnvio.Application.Services
{
    public class EnvioServiceService : IEnvioServiceService
    {
        private readonly IEnvioServicoRepository _repository;

        public EnvioServiceService(IEnvioServicoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EnvioServiceViewModel>> GetAll()
        {
            var envioServices = await _repository.GetAllAsync();

            return envioServices.Select(s => new EnvioServiceViewModel(s.Id, s.Titulo, s.PrecoPorKg, s.PrecoPorKg))
                                .ToList();
        }
    }
}
