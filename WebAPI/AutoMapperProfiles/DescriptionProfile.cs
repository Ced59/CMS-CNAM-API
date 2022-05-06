using AutoMapper;
using Dto.CommentairesDto;
using Dto.DescriptionsDto;
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
                ;
            CreateMap<DescriptionPostDto, Description>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
