using Rastreador.OrdemEnvio.Application.Dtos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreador.OrdemEnvio.Application.Services
{
    public interface IEnvioServiceService
    {
        Task<List<EnvioServiceViewModel>> GetAll();
    }
}
