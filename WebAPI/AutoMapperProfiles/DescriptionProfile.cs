using AutoMapper;
using Dto.CommentairesDto;
using Dto.DescriptionsDto;
using Entities.CommentairesEntities;
using Entities.DescriptionsEntitie;

namespace WebAPI.AutoMapperProfiles
{
    public class DescriptionProfile : Profile
    {
        public DescriptionProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Description, DescriptionDto>()
                .ForMember(c => c.IdProduit, opt => opt.Ignore());
        }

        private void MapDtoToEntities()
        {
            CreateMap<DescriptionDto, Description>()
                .ForMember(c => c.Produit, opt => opt.Ignore());
            CreateMap<DescriptionPostDto, Description>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.Produit, opt => opt.Ignore());
        }
    }
}
