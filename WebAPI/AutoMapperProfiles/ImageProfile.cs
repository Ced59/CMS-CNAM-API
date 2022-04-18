using AutoMapper;
using Dto.CommentairesDto;
using Dto.ImagesDto;
using Entities.CommentairesEntities;
using Entities.ImagesEntitie;

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
            CreateMap<Image, ImageDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<ImageDto, Image>();
            CreateMap<ImagePostDto, Image>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
