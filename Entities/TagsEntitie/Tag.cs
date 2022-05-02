using Entities.ProduitsEntitie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TagsEntitie
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateAjout { get; set; }
        public bool IsActif { get; set; }
        public virtual List<Produit> Produits { get; set; }
    }
}
