using Rastreador.OrdemEnvio.Application.Dtos.InputModels;
using Rastreador.OrdemEnvio.Application.Dtos.ViewModels;

namespace Rastreador.OrdemEnvio.Application.Services
{
    public interface IPedidoEnvioService
    {
        Task<string> Add(AddPedidoEnvioInputModel model);
        Task<PedidoEnvioViewModel> GetByCode(string codigoRastreamento);
    }
}
