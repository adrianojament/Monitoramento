namespace Monitoramento.Domain.Entities
{
    public class VideoEntity : PadraoEntity
    {
        public Guid ServidorId { get; set; }
        public virtual ServidorEntity Servidor { get; set; }
        public string Descricao { get; set; }
        public Byte[] Data { get; set; }
    }
}
