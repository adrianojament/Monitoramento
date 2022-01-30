using Microsoft.EntityFrameworkCore;
using Monitoramento.Domain.Entities;
using Monitoramento.Domain.Interfaces;
using Monitoramento.Infra.Data.Context;

namespace Monitoramento.Infra.Data.Repositories
{
    public class ServidorRepository : IServidorRepository
    {
        private MonitoramentoContexto _context;

        public ServidorRepository(MonitoramentoContexto context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ServidorEntity>> Recuperar()
        {
            return await _context.Servidores.ToListAsync();
        }
    }
}
