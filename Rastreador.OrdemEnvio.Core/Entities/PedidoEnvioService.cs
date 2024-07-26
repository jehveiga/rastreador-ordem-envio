namespace Rastreador.OrdemEnvio.Core.Entities
{
    public class PedidoEnvioService : EntityBase
    {
        public PedidoEnvioService(string titulo, decimal preco) : base()
        {
            Titulo = titulo;
            Preco = preco;
        }

        public string Titulo { get; private set; }
        public decimal Preco { get; private set; }
    }
}