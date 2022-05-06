using AutoMapper;
using Dto.MentionsLegalesDto;
using Entities.MentionsLegalesEntitie;

namespace WebAPI.AutoMapperProfiles
{
    public class MentionsLegalesProfile : Profile
    {
        public MentionsLegalesProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<MentionsLegales, MentionsLegalesDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<MentionsLegalesDto, MentionsLegales>()
                .ForMember(c => c.IsHistorique, opt => opt.Ignore());
            CreateMap<MentionsLegalesPostDto, MentionsLegales>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c=> c.IsHistorique, opt => opt.Ignore());
        }
    }
}
