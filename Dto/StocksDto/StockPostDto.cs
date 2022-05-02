using System;
using Dto.ProduitsDto;
using Newtonsoft.Json;

namespace Dto.StocksDto
{
    public class StockPostDto
    {
        [JsonProperty(PropertyName = "dateReapprovisionnement")]
        public DateTime? DateReapprovisionnement { get; set; }

        [JsonProperty(PropertyName = "quantite")]
        public int Quantite { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public Guid  IdProduit { get; set; }
    }
}
