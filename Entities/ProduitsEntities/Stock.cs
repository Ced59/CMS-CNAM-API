using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.ProduitsEntities
{
    public class Stock
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? DateReapprovisionnement { get; set; }
        public DateTime? DateModification{ get; set; }
        public int Quantite { get; set; }
        public virtual Produit Produit{ get; set; }

    }
}
