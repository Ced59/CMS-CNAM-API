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
            CreateMap<Commentaire, CommentaireDto>();
        }
        private void MapDtoToEntities()
        {
            CreateMap<CommentaireDto, Commentaire>();
            CreateMap<CommentairePostDto, Commentaire>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
