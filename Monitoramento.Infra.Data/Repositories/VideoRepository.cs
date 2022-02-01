using Monitoramento.Domain.Entities;
using Monitoramento.Domain.Interfaces.Repositories;
using Monitoramento.Infra.Data.Context;

namespace Monitoramento.Infra.Data.Repositories
{
    public class VideoRepository : PadraoRepository<VideoEntity>, IVideoRepository
    {
        public VideoRepository(MonitoramentoContexto context) : base(context)
        {
            _dataset = context.Set<VideoEntity>();
        }
    }
}
