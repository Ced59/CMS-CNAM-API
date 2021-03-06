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
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public double Tva { get; set; }
        public DateTime? DateAjout { get; set; }
        public bool IsActif { get; set; }
        public Description Description { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual List<Variant> Variants { get; set; }

    }
}
