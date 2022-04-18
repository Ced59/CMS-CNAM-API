using Entities.ProduitsEntitie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.StocksEntitie
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public DateTime? DateReapprovisionnement { get; set; }
        public DateTime? DateModification{ get; set; }
        public int Quantite { get; set; }

    }
}
