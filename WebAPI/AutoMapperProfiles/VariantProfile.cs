using AutoMapper;
using Dto.CommentairesDto;
using Dto.VariantsDto;
using Entities.ProduitsEntities;

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
            CreateMap<Variant, VariantDto>()
                .ForMember(c => c.Produits, opt => opt.Ignore());
        }

        private void MapDtoToEntities()
        {
            CreateMap<VariantDto, Variant>()
                .ForMember(c => c.DateAjout, opt => opt.Ignore())
                .ForMember(c => c.IsActif, opt => opt.Ignore())
                .ForMember(c => c.Produits, opt => opt.Ignore());
            CreateMap<VariantPostDto, Variant>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.DateAjout, opt => opt.Ignore())
                .ForMember(c => c.IsActif, opt => opt.Ignore())
                .ForMember(c => c.Produits, opt => opt.Ignore());
        }
    }
}
