using AutoMapper;
using Dto.ProduitsDto;
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
            CreateMap<ProduitDto, Produit>();
            CreateMap<ProduitPostDto, Produit>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
