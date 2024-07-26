using Rastreador.OrdemEnvio.Application.Dtos.InputModels;
using Rastreador.OrdemEnvio.Application.Dtos.ViewModels;
using Rastreador.OrdemEnvio.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreador.OrdemEnvio.Application.Services
{
    public class PedidoEnvioService : IPedidoEnvioService
    {
        private readonly IPedidoEnvioRepository _repository;

        public PedidoEnvioService(IPedidoEnvioRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Add(AddPedidoEnvioInputModel model)
        {
            var pedidoEnvio = model.ToEntity();

            var envioService = model.Servicos.Select(s => s.ToEntity()).ToList();

            pedidoEnvio.DefinirServicos(envioService);

            await _repository.AddAsync(pedidoEnvio);

            return pedidoEnvio.CodigoEnvio;
        }

        public async Task<PedidoEnvioViewModel> GetByCode(string codigoRastreamento)
        {
            var pedidoEnvio = await _repository.GetByCodeAsync(codigoRastreamento);

            return PedidoEnvioViewModel.FromEntity(pedidoEnvio);
        }
    }
}
