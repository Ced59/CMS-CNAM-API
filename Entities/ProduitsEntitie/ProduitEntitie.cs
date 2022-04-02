using Entities.DescriptionsEntitie;
using Entities.ImagesEntitie;
using Entities.StocksEntitie;
using Entities.TagsEntitie;
using Entities.VariantsEntitie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.ProduitsEntitie
{
    public class ProduitEntitie
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public double Tva { get; set; }
        public DateTime DateAjout { get; set; }
        public bool IsActif { get; set; }
        public virtual DescriptionEntitie Description { get; set; }
        public virtual StockEntitie Stock { get; set; }
        public virtual List<ImageEntitie> Images { get; set; }
        public virtual List<TagEntitie> Tags { get; set; }
        public virtual List<VariantEntitie> Variants { get; set; }

    }
}
