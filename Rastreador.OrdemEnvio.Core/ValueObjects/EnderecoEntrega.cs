namespace Rastreador.OrdemEnvio.Core.ValueObjects
{
    public class EnderecoEntrega
    {
        public EnderecoEntrega()
        {

        }

        public EnderecoEntrega(string rua, string numero, string cep, string cidade, string estado, string pais, string emailContato)
        {
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            EmailContato = emailContato;
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string EmailContato { get; private set; }





    }
        
        
        

}