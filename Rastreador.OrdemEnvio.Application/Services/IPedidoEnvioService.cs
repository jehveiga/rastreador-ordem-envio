using Rastreador.OrdemEnvio.Application.Dtos.InputModels;
using Rastreador.OrdemEnvio.Application.Dtos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreador.OrdemEnvio.Application.Services
{
    public interface IPedidoEnvioService
    {
        Task<string> Add(AddPedidoEnvioInputModel model);
        Task<PedidoEnvioViewModel> GetByCode(string codigoRastreamento);
    }
}
