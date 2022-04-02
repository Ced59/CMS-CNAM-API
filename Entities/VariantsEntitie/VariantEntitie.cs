using Entities.ProduitsEntitie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VariantsEntitie
{
    public class VariantEntitie
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Descriptif { get; set; }
        public DateTime DateAjout { get; set; }
        public bool IsActif { get; set; }
        public virtual List<ProduitEntitie> Produits { get; set; }
    }
}
