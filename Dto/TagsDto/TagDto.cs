using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.ProduitsDto;
using Newtonsoft.Json;

namespace Dto.TagsDto
{
    public class TagDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public  List<int> IdProduits { get; set; }
    }
}
