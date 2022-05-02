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
            CreateMap<ExempleDto, Exemple>()
                .ForMember(c => c.IsArchived, opt => opt.Ignore())
                ;
            CreateMap<ExemplePostDto, Exemple>()
                .ForMember(c => c.IsArchived, opt => opt.Ignore())
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
