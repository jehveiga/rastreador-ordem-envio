using Rastreador.OrdemEnvio.Core.Entities;
using Rastreador.OrdemEnvio.Core.ValueObjects;

namespace Rastreador.OrdemEnvio.Application.Dtos.InputModels
{
    public class AddPedidoEnvioInputModel
    {
        public string Descricao { get; set; } = string.Empty;
        public decimal PesoEmKg { get; set; }
        public EnderecoEntregaInputModel EnderecoEntrega { get; set; } = new EnderecoEntregaInputModel();
        public List<EnvioServiceInputModel> Servicos { get; set; } = new List<EnvioServiceInputModel>();

        public PedidoEnvio ToEntity()
            => new PedidoEnvio(
                Descricao,
                PesoEmKg,
                EnderecoEntrega.ToValueObject()
        );
    }


    public class EnderecoEntregaInputModel
    {
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public string EmailContato { get; set; } = string.Empty;

        // Metodo resposanvel por entregar um objeto de valor EnderecoEntrega
        public EnderecoEntrega ToValueObject()
            => new EnderecoEntrega(Rua, Numero, Cep, Cidade, Estado, Pais, EmailContato);
    }

    public class EnvioServiceInputModel
    {
        public string Titulo { get; set; } = string.Empty;
        public decimal PrecoPorKg { get; set; }
        public decimal PrecoFixado { get; set; }

        // Método responsável por entregar uma entidade EnvioService
        public EnvioService ToEntity()
            => new EnvioService(Titulo, PrecoPorKg, PrecoFixado);
    }
}
