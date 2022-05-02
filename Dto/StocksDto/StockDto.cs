using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.ProduitsDto;
using Newtonsoft.Json;

namespace Dto.StocksDto
{
    public class StockDto
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "dateReapprovisionnement")]
        public DateTime? DateReapprovisionnement { get; set; }

        [JsonProperty(PropertyName = "quantite")]
        public int Quantite { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public Guid IdProduit { get; set; }

    }
}
