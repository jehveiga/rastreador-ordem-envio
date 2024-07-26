using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rastreador.OrdemEnvio.Core.Enums;
using Rastreador.OrdemEnvio.Core.ValueObjects;

namespace Rastreador.OrdemEnvio.Core.Entities
{
    public class PedidoEnvio : EntityBase
    {
        public PedidoEnvio(string descricao, decimal pesoEmKg, EnderecoEntrega enderecoEntrega) : base()
        {
            Descricao = descricao;
            PostadoEm = DateTime.Now;
            PesoEmKg = pesoEmKg;
            EnderecoEntrega = enderecoEntrega;

            Status = PedidoEnvioStatus.Iniciado;
            Servicos = new List<PedidoEnvioService>();
        }

        public string CodigoEnvio { get; private set; }
        public string Descricao { get; private set; }
        public DateTime PostadoEm { get; private set; }
        public decimal PesoEmKg { get; private set; }
        public EnderecoEntrega EnderecoEntrega { get; private set; }
        public PedidoEnvioStatus Status { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public List<PedidoEnvioService> Servicos { get; private set; }

        public void DefinirServicos(List<EnvioService> servicos)
        {
            foreach (EnvioService servico in servicos)
            {
                var precoServico = servico.PrecoFixado + servico.PrecoPorKg * PesoEmKg;

                PrecoTotal += precoServico;

                Servicos.Add(new PedidoEnvioService(servico.Titulo, precoServico));
            }
        }

            // Método responsável por  gerar o código de envio
            private string GerarCodigoEnvio()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";

            var code = new char[10];
            var random = new Random();

            for (var i = 0; i < 5; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            for (var i = 5; i < 10; i++)
            {
                code[i] = numbers[random.Next(numbers.Length)];
            }

            return new String(code);
        }
    }
}
