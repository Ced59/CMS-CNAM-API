using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MentionsLegalesEntitie
{
    public class MentionsLegales
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mentions { get; set; }
        public bool IsHistorique { get; set; }
        public DateTime DateAjout { get; set; }
    }
}
