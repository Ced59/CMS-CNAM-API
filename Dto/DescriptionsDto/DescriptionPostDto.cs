using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.ProduitsDto;
using Entities.ProduitsEntitie;
using Newtonsoft.Json;

namespace Dto.DescriptionsDto
{
    public class DescriptionPostDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "information")]
        public string Information { get; set; }

        [JsonProperty(PropertyName = "dateDescription")]
        public DateTime? DateDescription { get; set; }

        [JsonProperty(PropertyName = "isActif")]
        public bool IsActif { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public int IdProduit { get; set; }
    }
}
