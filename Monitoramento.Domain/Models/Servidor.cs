namespace Monitoramento.Domain.Models
{
    public class Servidor : Padrao
    {
        public string Nome { get; set; }
        public string IP_Endereco { get; set; }
        public int IP_Porta { get; set; }
    }
}
