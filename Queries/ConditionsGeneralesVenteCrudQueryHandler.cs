using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.ConditionsGeneralesVenteEntitie;
using Entities.DatabasesContext;
using Microsoft.EntityFrameworkCore;
using Queries.Interface;


namespace Queries
{
public class ConditionsGeneralesVenteCrudQueryHandler : ICrudInterface<ConditionsGeneralesVente>
    {
        private readonly DatabaseContext _db;

        public ConditionsGeneralesVenteCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Historique(Guid id)
        {
            ConditionsGeneralesVente Condition = _db.ConditionsGeneralesVente.FirstOrDefault(u => u.Id == id);
            Condition.Historique = true;
            _db.ConditionsGeneralesVente.Update(Condition);
            _db.SaveChanges();
        }

        public IEnumerable<ConditionsGeneralesVente> GetAll()
        {
            return _db.ConditionsGeneralesVente;
        }

        public ConditionsGeneralesVente GetById(Guid id)
        {
            return _db.ConditionsGeneralesVente.FirstOrDefault(e => e.Id == id);
        }

        public void Post(ConditionsGeneralesVente entity)
        {
            _db.ConditionsGeneralesVente.Add(entity);
            _db.SaveChanges();
        }

        public void Put(ConditionsGeneralesVente entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

        public void Archive(Guid id)
        {
            ConditionsGeneralesVente Condition = _db.ConditionsGeneralesVente.FirstOrDefault(u => u.Id == id);
            Condition.Historique = false;
            _db.ConditionsGeneralesVente.Update(Condition);
            _db.SaveChanges();
        }
    }
}
