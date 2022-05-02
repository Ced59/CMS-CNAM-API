using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CommentairesEntities
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
