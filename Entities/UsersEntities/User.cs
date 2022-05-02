using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UsersEntities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Civilite { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UrlPhoto { get; set; }
        public bool IsArchived { get; set; }
        public string Role { get; set; }
    }
}
