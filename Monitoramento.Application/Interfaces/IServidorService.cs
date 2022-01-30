using Monitoramento.Application.ViewModel;

namespace Monitoramento.Application.Interfaces
{
    public interface IServidorService
    {
        Task<ServidorViewModel> Recuperar();
    }
}
