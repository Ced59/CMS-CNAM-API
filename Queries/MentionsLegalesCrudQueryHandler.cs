using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DatabasesContext;
using Entities.MentionsLegalesEntitie;
using Queries.Interface;

namespace Queries
{
    public class MentionsLegalesCrudQueryHandler : ICrudInterface<MentionsLegales>
    {
      
        {
        private readonly DatabaseContext _db;

        public MentionsLegalesCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Historique(Guid id)
        {
            MentionsLegales mention = _db.MentionsLegales.FirstOrDefault(u => u.Id == id);
            mention.Historique = true;
            _db.MentionsLegales.Update(mention);
            _db.SaveChanges();
        }

        public IEnumerable<MentionsLegales> GetAll()
        {
            return _db.MentionsLegales;
        }

        public MentionsLegales GetById(Guid id)
        {
            return _db.MentionsLegales.FirstOrDefault(e => e.Id == id);
        }

        public void Post(MentionsLegales entity)
        {
            _db.MentionsLegales.Add(entity);
            _db.SaveChanges();
        }

        public void Put(MentionsLegales entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

        public void Archive(Guid id)
        {
            MentionsLegales Condition = _db.MentionsLegales.FirstOrDefault(u => u.Id == id);
            Condition.Historique = false;
            _db.MentionsLegales.Update(Condition);
            _db.SaveChanges();
        }

       
    }
}