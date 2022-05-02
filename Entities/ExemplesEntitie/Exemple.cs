﻿using System.ComponentModel.DataAnnotations;

namespace Entities.ExemplesEntitie
{
    public class Exemple
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}