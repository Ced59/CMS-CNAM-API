using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.ProduitsEntities
{
    public class Variant
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descriptif { get; set; }
        public DateTime? DateAjout { get; set; }
        public bool IsActif { get; set; }
        public  List<Produit> Produits { get; set; }
    }
}
