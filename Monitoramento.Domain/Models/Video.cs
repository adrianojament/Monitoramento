namespace Monitoramento.Domain.Models
{
    public class Video : Padrao
    {
        public Guid ServidorId { get; set; }
        public string Descricao { get; set; }
        public Byte[] Data { get; set; }
    }
}
