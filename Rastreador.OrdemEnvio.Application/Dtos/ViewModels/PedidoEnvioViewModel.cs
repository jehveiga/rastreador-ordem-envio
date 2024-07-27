using Rastreador.OrdemEnvio.Core.Entities;

namespace Rastreador.OrdemEnvio.Application.Dtos.ViewModels
{
    public class PedidoEnvioViewModel
    {
        public PedidoEnvioViewModel(string codigoRastreio, string descricao, DateTime postadoEm, decimal pesoEmKg, string enderecoCompleto)
        {
            CodigoRastreio = codigoRastreio;
            Descricao = descricao;
            PostadoEm = postadoEm;
            PesoEmKg = pesoEmKg;
            EnderecoCompleto = enderecoCompleto;
        }

        public string CodigoRastreio { get; private set; }
        public string Descricao { get; private set; }
        public DateTime PostadoEm { get; private set; }
        public decimal PesoEmKg { get; private set; }
        public string EnderecoCompleto { get; private set; }

        // Método responsável por entregar um objeto View Model
        public static PedidoEnvioViewModel FromEntity(PedidoEnvio pedidoEnvio)
        {
            var endereco = pedidoEnvio.EnderecoEntrega;

            return new PedidoEnvioViewModel(
                pedidoEnvio.CodigoEnvio,
                pedidoEnvio.Descricao,
                pedidoEnvio.PostadoEm,
                pedidoEnvio.PesoEmKg,
                $"{endereco.Rua}, {endereco.Numero}, {endereco.Cep}, {endereco.Cidade}, {endereco.Estado}, {endereco.Pais}"
            );
        }
    }
}
