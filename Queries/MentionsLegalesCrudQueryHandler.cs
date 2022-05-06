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
      
        
        private readonly DatabaseContext _db;

        public MentionsLegalesCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Post(MentionsLegales entity)
        {
            _db.MentionsLegales.Add(entity);
            _db.SaveChanges();
        }
        public MentionsLegales GetById(Guid id)
        {
            return _db.MentionsLegales.FirstOrDefault(c => c.Id == id);
        }
        public IEnumerable<MentionsLegales> GetAll()
        {
            return _db.MentionsLegales;
        }

        public void Put(MentionsLegales entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

        public void Archive(Guid id)
        {
            MentionsLegales MentionsLegales = _db.MentionsLegales.FirstOrDefault(c => c.Id == id);
            MentionsLegales.IsHistorique = true;
            _db.MentionsLegales.Update(MentionsLegales);
            _db.SaveChanges();
        }

       
    }
}