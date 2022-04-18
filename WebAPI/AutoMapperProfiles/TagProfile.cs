using AutoMapper;
using Dto.CommentairesDto;
using Dto.TagsDto;
using Entities.CommentairesEntities;
using Entities.TagsEntitie;

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
            CreateMap<Tag, TagDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<TagDto, Tag>();
            CreateMap<TagPostDto, Tag>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
