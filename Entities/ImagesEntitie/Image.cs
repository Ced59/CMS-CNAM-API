using Entities.ProduitsEntitie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ImagesEntitie
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Url { get; set; }
        public DateTime? DateAjout { get; set; }
        public bool IsActif { get; set; }
        public virtual List<Produit> Produits{ get; set; }
    }
}
