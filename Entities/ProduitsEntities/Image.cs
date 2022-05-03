using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.ProduitsEntities
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Url { get; set; }
        public DateTime? DateAjout { get; set; }
        public bool IsActif { get; set; }
        public  Produit Produit { get; set; }
    }
}
