using AutoMapper;
using Dto.CommentairesDto;
using Entities.ProduitsEntities;

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
            CreateMap<CommentaireDto, Commentaire>()
                .ForMember(c => c.IsArchived, opt => opt.Ignore());
            CreateMap<CommentairePostDto, Commentaire>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.IsArchived, opt => opt.Ignore());
        }
    }
}
