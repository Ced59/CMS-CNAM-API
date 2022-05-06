using AutoMapper;
using Dto.CommentairesDto;
using Dto.ImagesDto;
using Entities.ProduitsEntities;

namespace WebAPI.AutoMapperProfiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Image, ImageDto>()
                .ForMember(c => c.IdProduit, opt => opt.Ignore());
        }

        private void MapDtoToEntities()
        {
            CreateMap<ImageDto, Image>()
                .ForMember(c => c.Produit, opt => opt.Ignore())
                .ForMember(c => c.IsArchived, opt => opt.Ignore());
            CreateMap<ImagePostDto, Image>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.Produit, opt => opt.Ignore())
                .ForMember(c => c.IsArchived, opt => opt.Ignore());
        }
    }
}
