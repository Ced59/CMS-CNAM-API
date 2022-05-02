using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.ProduitsDto;
using Newtonsoft.Json;

namespace Dto.VariantsDto
{
    public class VariantPostDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Descriptif { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public List<Guid> Produits { get; set; }
    }
}
