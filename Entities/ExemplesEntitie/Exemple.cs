using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.ExemplesEntitie
{
    public class Exemple
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set; }
    }
}