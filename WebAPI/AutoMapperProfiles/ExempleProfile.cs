using AutoMapper;
using Dto.ExemplesDto;
using Entities.ExemplesEntitie;

namespace WebAPI.AutoMapperProfiles
{
    public class ExempleProfile : Profile
    {
        public ExempleProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Exemple, ExempleDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<ExempleDto, Exemple>();
        }
    }
}
