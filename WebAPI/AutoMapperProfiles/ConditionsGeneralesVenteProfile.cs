using AutoMapper;
using Dto.CommentairesDto;
using Dto.ConditionsGeneralesVenteDto;
using Entities.CommentairesEntities;
using Entities.ConditionsGeneralesVenteEntitie;
namespace WebAPI.AutoMapperProfiles
{
    public class ConditionsGeneralesVenteProfile : Profile
    {
        public ConditionsGeneralesVenteProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<ConditionsGeneralesVente, ConditionsGeneralesDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<ConditionsGeneralesDto, ConditionsGeneralesVente>()
                .ForMember(c => c.IsHistorique, opt => opt.Ignore());
            CreateMap<ConditionsGeneralesPostDto, ConditionsGeneralesVente>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.IsHistorique, opt => opt.Ignore());
        }
    }
}
