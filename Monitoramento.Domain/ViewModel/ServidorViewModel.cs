using Monitoramento.Domain.Models;

namespace Monitoramento.Domain.ViewModel
{
    public class ServidorViewModel : BaseViewModel
    {
        public IEnumerable<Servidor> Servidores { get; set; }
        public Servidor Servidor { get; set; }
    }
}
