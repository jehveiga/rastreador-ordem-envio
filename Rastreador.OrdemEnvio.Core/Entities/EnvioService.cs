namespace Rastreador.OrdemEnvio.Core.Entities
{
    public class EnvioService : EntityBase
    {
        public EnvioService(string titulo, decimal precoPorKg, decimal precoFixado) : base()
        {
            Titulo = titulo;
            PrecoPorKg = precoPorKg;
            PrecoFixado = precoFixado;
        }

        public string Titulo { get; private set; }
        public decimal  PrecoPorKg { get; private set; }
        public decimal PrecoFixado { get; private set; }
    }
}