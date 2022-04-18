using AutoMapper;
using Dto.CommentairesDto;
using Dto.VariantsDto;
using Entities.CommentairesEntities;
using Entities.VariantsEntitie;

namespace WebAPI.AutoMapperProfiles
{
    public class VariantProfile : Profile
    {
        public VariantProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Variant, VariantDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<VariantDto, Variant>();
            CreateMap<VariantPostDto, Variant>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
