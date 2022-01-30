namespace Monitoramento.Domain.Entities
{
    public class ServidorEntity : PadraoEntity
    {
        public string Nome { get; set; }
        public string IP_Endereco { get; set; }
        public int IP_Porta { get; set; }
        public virtual IEnumerable<VideoEntity> Videos { get; set; }
    }
}
