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
            CreateMap<Stock, StockDto>();
        }

        private void MapDtoToEntities()
        {
            CreateMap<StockDto, Stock>();
            CreateMap<StockPostDto, Stock>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
