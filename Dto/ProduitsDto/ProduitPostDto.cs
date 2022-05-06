﻿using System;
using System.Collections.Generic;
using Dto.DescriptionsDto;
using Dto.ImagesDto;
using Dto.StocksDto;
using Dto.TagsDto;
using Dto.VariantsDto;
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

        [JsonProperty(PropertyName = "isArchived")]
        public bool IsArchived { get; set; }

        [JsonProperty(PropertyName = "description")]
        public DescriptionPostDto Description { get; set; }

        [JsonProperty(PropertyName = "stock")]
        public StockPostDto Stock { get; set; }

        [JsonProperty(PropertyName = "images")]
        public virtual List<ImagePostDto> Images { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public virtual List<TagPostDto> Tags { get; set; }

        [JsonProperty(PropertyName = "variants")]
        public virtual List<VariantPostDto> Variants { get; set; }
    }
}
