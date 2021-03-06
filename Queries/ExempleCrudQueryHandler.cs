using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DatabasesContext;
using Entities.ExemplesEntitie;
using Microsoft.EntityFrameworkCore;
using Queries.Interface;

namespace Queries
{
    public class ExempleCrudQueryHandler : ICrudInterface<Exemple>
    {
        private readonly DatabaseContext _db;

        public ExempleCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }


        public IEnumerable<Exemple> GetAll()
        {
            return _db.Exemples;
        }

        public Exemple GetById(int id)
        {
            return _db.Exemples.FirstOrDefault(e => e.Id == id);
        }

        public void Post(Exemple entity)
        {
            _db.Exemples.Add(entity);
            _db.SaveChanges();
        }

        public void Put(Exemple entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}
