namespace Rastreador.OrdemEnvio.Core.Entities
{
    public abstract class EntityBase
    {

        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
