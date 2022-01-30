namespace Monitoramento.Domain.Models
{
    public abstract class Padrao
    {
        public Guid Id { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Alteracao { get; set; }
    }
}
