﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.ProduitsEntities
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateAjout { get; set; }
        public bool IsArchived { get; set; }
        public virtual List<Produit> Produits { get; set; }
    }
}
