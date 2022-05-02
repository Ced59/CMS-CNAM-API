using AutoMapper;
using Dto.CommentairesDto;
using Dto.ProduitsDto;
using Entities.CommentairesEntities;
using Entities.ProduitsEntitie;

namespace WebAPI.AutoMapperProfiles
{
    public class ProduitProfile : Profile
    {
        public ProduitProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Produit, ProduitDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<ProduitDto, Produit>()
                .ForMember(c => c.IsArchived, opt => opt.Ignore());

            CreateMap<ProduitPostDto, Produit>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.IsArchived, opt => opt.Ignore());
        }
    }
}
