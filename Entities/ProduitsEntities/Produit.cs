using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.DescriptionsEntitie;

namespace Entities.ProduitsEntities
{
    public class Produit
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public double Tva { get; set; }
        public DateTime? DateAjout { get; set; }
        public bool IsArchived { get; set; }
        public Description Description { get; set; }
        public  List<Image> Images { get; set; }
        public  List<Tag> Tags { get; set; }
        public  List<Variant> Variants { get; set; }
        public  List<Commentaire> Commentaires { get; set; }

    }
}
