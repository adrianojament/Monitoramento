using Monitoramento.Domain.Entities;
using System.Linq.Expressions;

namespace Monitoramento.Domain.Interfaces.Repositories
{
    public interface IPadraoRepository<TEntity> where TEntity : PadraoEntity
    {
        Task<TEntity> InsertAsync(TEntity item);
        Task<TEntity> UpdateAsync(TEntity item);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistAsync(Guid id);
        Task<TEntity> SelectAsync(Guid id);
        Task<IEnumerable<TEntity>> SelectAsync();
        Task<IEnumerable<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> condition);
    }
}
