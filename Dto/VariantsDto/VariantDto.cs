using Dto.ProduitsDto;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dto.VariantsDto
{
    public class VariantDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Descriptif { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public List<int> Produits { get; set; }
    }
}
