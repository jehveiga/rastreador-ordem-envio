using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreador.OrdemEnvio.Application.Dtos.ViewModels
{
    public class EnvioServiceViewModel
    {
        public EnvioServiceViewModel(Guid id, string titulo, decimal precoPorKg, decimal precoFixado)
        {
            Id = id;
            Titulo = titulo;
            PrecoPorKg = precoPorKg;
            PrecoFixado = precoFixado;
        }

        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public decimal PrecoPorKg { get; private set; }
        public decimal PrecoFixado { get; private set; }
    }
}
