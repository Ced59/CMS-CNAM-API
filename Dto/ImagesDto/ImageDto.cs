using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.ProduitsDto;
using Newtonsoft.Json;

namespace Dto.ImagesDto
{
    public class ImageDto
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "information")]
        public string Information { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "dateAjout")]
        public DateTime? DateAjout { get; set; }

        [JsonProperty(PropertyName = "isActif")]
        public bool IsActif { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public Guid IdProduit { get; set; }
    }
}
