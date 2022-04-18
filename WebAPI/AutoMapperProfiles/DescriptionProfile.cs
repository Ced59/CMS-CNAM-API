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
            CreateMap<Description, DescriptionDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<DescriptionDto, Description>();
            CreateMap<DescriptionPostDto, Description>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
