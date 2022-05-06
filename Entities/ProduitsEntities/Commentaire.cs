using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.ProduitsEntities
{
    public class Commentaire
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Note { get; set; }
        public bool IsArchived { get; set; }
        public Guid ProduitId { get; set; }
        public Guid UserId { get; set; }
    }
}
