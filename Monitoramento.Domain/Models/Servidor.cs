using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoramento.Domain.Models
{
    public class Servidor : Padrao
    {
        public string Nome { get; set; }
        public string IP_Endereco { get; set; }
        public int IP_Porta { get; set; }
    }
}
