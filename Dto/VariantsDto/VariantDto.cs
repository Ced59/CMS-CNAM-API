using System;
using Dto.ProduitsDto;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dto.VariantsDto
{
    public class VariantDto
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Descriptif { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public List<Guid> Produits { get; set; }
    }
}
