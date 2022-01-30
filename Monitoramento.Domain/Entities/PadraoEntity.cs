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
                if (_AtualizadoEm == null)
                {
                    _AtualizadoEm = Helpers.Helpers.GetDateTimeBrasilian();
                }
                return _AtualizadoEm;
            }
            set => _AtualizadoEm = value;
        }
        public DateTime? CriadoEm
        {
            get
            {
                if (_CriadoEm == null)
                {
                    _CriadoEm = Helpers.Helpers.GetDateTimeBrasilian();
                }
                return _CriadoEm;
            }
            set => _CriadoEm = value;
        }
    }
}
