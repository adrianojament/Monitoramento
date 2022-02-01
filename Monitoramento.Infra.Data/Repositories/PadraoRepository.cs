using Microsoft.EntityFrameworkCore;
using Monitoramento.Application;
using Monitoramento.Domain.Entities;
using Monitoramento.Domain.Interfaces.Repositories;
using Monitoramento.Infra.Data.Context;
using System.Linq.Expressions;

namespace Monitoramento.Infra.Data.Repositories
{
    public abstract class PadraoRepository<Entity> : IPadraoRepository<Entity> where Entity : PadraoEntity
    {
        protected readonly MonitoramentoContexto _context;
        protected DbSet<Entity> _dataset;

        public PadraoRepository(MonitoramentoContexto context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null)
                {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<Entity> InsertAsync(Entity item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }

                item.AtualizadoEm = Utils.GetDateTimeBrasilian();
                item.CriadoEm = Utils.GetDateTimeBrasilian();
                _dataset.Add(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<Entity> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Entity>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Entity>> SelectAsync(Expression<Func<Entity, bool>> condition)
        {
            try
            {
                return await _dataset.Where(condition).ToListAsync<Entity>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Entity> UpdateAsync(Entity item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null)
                {
                    return null;
                }

                item.AtualizadoEm = Utils.GetDateTimeBrasilian();
                item.CriadoEm = result.CriadoEm;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
