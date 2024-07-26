using Rastreador.OrdemEnvio.Application.Dtos.ViewModels;
using Rastreador.OrdemEnvio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreador.OrdemEnvio.Application.Services
{
    public class EnvioServiceService : IEnvioServiceService
    {
        public Task<List<EnvioServiceViewModel>> GetAll()
        {
            var envioServices = new List<EnvioService> {
                new EnvioService("Selo", 0, 1.2m),
                new EnvioService("Envio com Registro", 2.2m, 5),
                new EnvioService("Envio sem Registro", 1, 3)
            };

            return Task.FromResult(
                envioServices
                    .Select(s => new EnvioServiceViewModel(s.Id, s.Titulo, s.PrecoPorKg, s.PrecoPorKg))
                    .ToList()
            );
        }
    }
}
