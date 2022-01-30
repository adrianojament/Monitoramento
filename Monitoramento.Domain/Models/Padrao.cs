using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoramento.Domain.Models
{
    public abstract class Padrao
    {
        public Guid Id { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Alteracao { get; set; }
    }
}
