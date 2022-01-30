using AutoMapper;
using Monitoramento.Application.Interfaces;
using Monitoramento.Application.ViewModel;
using Monitoramento.Domain.Interfaces;
using Monitoramento.Domain.Models;

namespace Monitoramento.Application.Services
{
    public class ServidorService : IServidorService
    {
        private IServidorRepository _repository;
        private readonly IMapper _mapper;

        public ServidorService(IServidorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ServidorViewModel> Recuperar()
        {
            return new ServidorViewModel()
            {
                Servidores = _mapper.Map<IEnumerable<Servidor>>(await _repository.Recuperar()),
            };
        }
    }
}
