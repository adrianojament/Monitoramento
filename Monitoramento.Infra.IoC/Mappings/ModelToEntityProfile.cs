using AutoMapper;
using Monitoramento.Domain.Entities;
using Monitoramento.Domain.Models;

namespace Monitoramento.Infra.IoC.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            _mappingServidor();
            _mappingVideo();
        }

        private void _mappingVideo()
        {
            CreateMap<VideoEntity, Video>().ReverseMap();
        }

        private void _mappingServidor()
        {
            CreateMap<ServidorEntity, Servidor>().ReverseMap();
        }
    }
}
