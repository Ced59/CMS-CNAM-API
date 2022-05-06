using System;
using System.Collections.Generic;
using Dto.ProduitsDto;
using Newtonsoft.Json;

namespace Dto.ImagesDto
{
    public class ImagePostDto
    {
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
