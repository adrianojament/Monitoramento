using System.ComponentModel.DataAnnotations;

namespace Monitoramento.Domain.Entities
{
    public abstract class PadraoEntity
    {
        DateTime? _CriadoEm;
        DateTime? _AtualizadoEm;

        [Key]
        public Guid Id { get; set; }

        public DateTime? AtualizadoEm
        {
            get
            {
                return _AtualizadoEm;
            }
            set => _AtualizadoEm = value;
        }
        public DateTime? CriadoEm
        {
            get
            {
                return _CriadoEm;
            }
            set => _CriadoEm = value;
        }
    }
}
