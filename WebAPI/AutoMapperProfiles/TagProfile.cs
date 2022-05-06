using AutoMapper;
using Dto.CommentairesDto;
using Dto.TagsDto;
using Entities.ProduitsEntities;

namespace WebAPI.AutoMapperProfiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Tag, TagDto>()
                .ForMember(c => c.IdProduits, opt => opt.Ignore());
        }

        private void MapDtoToEntities()
        {
            CreateMap<TagDto, Tag>()
                .ForMember(c => c.DateAjout, opt => opt.Ignore())
                .ForMember(c => c.IsActif, opt => opt.Ignore())
                .ForMember(c => c.Produits, opt => opt.Ignore());
            CreateMap<TagPostDto, Tag>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.DateAjout, opt => opt.Ignore())
                .ForMember(c => c.IsActif, opt => opt.Ignore())
                .ForMember(c => c.Produits, opt => opt.Ignore());
        }
    }
}
