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

        public void Archive(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConditionsGeneralesVente> GetAll()
        {
            List<ConditionsGeneralesVente> ConditionsGeneralesVentes = null;

            using (_db)
            {
                ConditionsGeneralesVentes = new List<ConditionsGeneralesVente>();
                ConditionsGeneralesVentes = _db.ConditionsGeneralesVentes.ToList();
            }
            return ConditionsGeneralesVentes;
        }

        public ConditionsGeneralesVente GetById(Guid id)
        {
            ConditionsGeneralesVente ConditionsGeneralesVente = null;
            using (_db)
            {
                ConditionsGeneralesVente = new ConditionsGeneralesVente();
                ConditionsGeneralesVente = _db.ConditionsGeneralesVentes.FirstOrDefault(d => d.IsHistorique && d.Id == id);
            }
            return ConditionsGeneralesVente;
        }

        public void Post(ConditionsGeneralesVente entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.ConditionsGeneralesVentes.Add(entity);
                _db.SaveChanges();
            }
        }
        public void Put(ConditionsGeneralesVente entity)
        {
            using (_db)
            {
                _db.ConditionsGeneralesVentes.Update(entity);
                _db.SaveChanges();
            }
        }

    }


}

