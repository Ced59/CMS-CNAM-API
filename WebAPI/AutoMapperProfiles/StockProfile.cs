using AutoMapper;
using Dto.CommentairesDto;
using Dto.StocksDto;
using Entities.CommentairesEntities;
using Entities.StocksEntitie;

namespace WebAPI.AutoMapperProfiles
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            MapDtoToEntities();
            MapEntitiesToDto();
        }

        private void MapEntitiesToDto()
        {
            CreateMap<Stock, StockDto>()
                .ForMember(c => c.IdProduit, opt => opt.Ignore());
        }

        private void MapDtoToEntities()
        {
            CreateMap<StockDto, Stock>()
                .ForMember(c => c.DateModification, opt => opt.Ignore())
                .ForMember(c => c.Produit, opt => opt.Ignore());
            CreateMap<StockPostDto, Stock>()
                .ForMember(c => c.Id , opt => opt.Ignore())
                .ForMember(c=> c.DateModification, opt => opt.Ignore())
                .ForMember(c => c.Produit, opt => opt.Ignore());
        }
    }
}
