using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.ProduitsDto;
using Newtonsoft.Json;

namespace Dto.TagsDto
{
    public class TagPostDto
    {
        [JsonProperty(PropertyName = "title")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public List<int> IdProduits { get; set; }
    }
}
