using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.DescriptionsDto;
using Dto.ImagesDto;
using Dto.StocksDto;
using Dto.TagsDto;
using Dto.VariantsDto;
using Entities.DescriptionsEntitie;
using Entities.ImagesEntitie;
using Entities.StocksEntitie;
using Entities.TagsEntitie;
using Entities.VariantsEntitie;
using Newtonsoft.Json;

namespace Dto.ProduitsDto
{
    public class ProduitDto
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "price")]
        public float Price { get; set; }
        
        [JsonProperty(PropertyName = "tva")]
        public double Tva { get; set; }
        
        [JsonProperty(PropertyName = "dateAjout")]
        public DateTime? DateAjout { get; set; }
        
        [JsonProperty(PropertyName = "isActif")]
        public bool IsActif { get; set; }

        [JsonProperty(PropertyName = "description")]
        public DescriptionDto Description { get; set; }

        [JsonProperty(PropertyName = "images")]
        public virtual List<ImageDto> Images { get; set; }
        
        [JsonProperty(PropertyName = "tags")]
        public virtual List<TagDto> Tags { get; set; }
        
        [JsonProperty(PropertyName = "variants")]
        public virtual List<VariantDto> Variants { get; set; }
    }
}
