using Monitoramento.Domain.Models;
using Monitoramento.Domain.ViewModel;

namespace Monitoramento.Domain.Interfaces.Services
{
    public interface IServidorService
    {
        Task<ServidorViewModel> Recuperar();
        Task<ServidorViewModel> Recuperar(Guid id);
        Task<ServidorViewModel> Adicionar(Servidor viewModel);
        Task<ServidorViewModel> Atualizar(Servidor viewModel);
        Task<bool> Remover(Guid id);
    }
}
