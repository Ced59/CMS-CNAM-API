﻿using System;
using System.Collections.Generic;
using Entities.DescriptionsEntitie;
using Entities.ImagesEntitie;
using Entities.StocksEntitie;
using Entities.TagsEntitie;
using Entities.VariantsEntitie;
using Newtonsoft.Json;

namespace Dto.ProduitsDto
{
    public class ProduitPostDto
    {
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

        [JsonProperty(PropertyName = "idDescription")]
        public virtual Description Description { get; set; }

        [JsonProperty(PropertyName = "idStock")]
        public virtual Stock Stock { get; set; }

        [JsonProperty(PropertyName = "idImage")]
        public virtual List<Image> Images { get; set; }

        [JsonProperty(PropertyName = "idTag")]
        public virtual List<Tag> Tags { get; set; }

        [JsonProperty(PropertyName = "idVariant")]
        public virtual List<Variant> Variants { get; set; }
    }
}