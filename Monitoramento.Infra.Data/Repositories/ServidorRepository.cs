using Monitoramento.Domain.Entities;
using Monitoramento.Domain.Interfaces.Repositories;
using Monitoramento.Infra.Data.Context;

namespace Monitoramento.Infra.Data.Repositories
{
    public class ServidorRepository : PadraoRepository<ServidorEntity>, IServidorRepository
    {
        public ServidorRepository(MonitoramentoContexto context) : base(context)
        {
            _dataset = context.Set<ServidorEntity>();
        }
    }
}
