using Monitoramento.Domain.Entities;

namespace Monitoramento.Domain.Interfaces
{
    public interface IServidorRepository
    {
        public Task<IEnumerable<ServidorEntity>> Recuperar();
    }
}
