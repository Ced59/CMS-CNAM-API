using Entities.ProduitsEntitie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DescriptionsEntitie
{
    public class Description
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public DateTime? DateDescription { get; set; }
        public bool IsActif { get; set; }
    }
}
