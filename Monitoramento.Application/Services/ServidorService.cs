using AutoMapper;
using Monitoramento.Domain.Interfaces.Repositories;
using Monitoramento.Domain.Interfaces.Services;
using Monitoramento.Domain.Models;
using Monitoramento.Domain.ViewModel;

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
                Servidores = _mapper.Map<IEnumerable<Servidor>>(await _repository.SelectAsync()),
            };
        }

        public Task<ServidorViewModel> Recuperar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ServidorViewModel> Adicionar(Servidor viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<ServidorViewModel> Atualizar(Servidor viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
