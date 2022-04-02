using AutoMapper;
using Dto.CommentairesDto;
using Entities.CommentairesEntities;

namespace WebAPI.AutoMapperProfiles
{
    public class CommentaireProfile : Profile
    {
        public CommentaireProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Commentaire, ImageDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<ImageDto, Commentaire>();
            CreateMap<StockPostDto, Commentaire>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
