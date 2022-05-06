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

        public void Archive(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MentionsLegales> GetAll()
        {
            List<MentionsLegales> MentionsLegales = null;

            using (_db)
            {
                MentionsLegales = new List<MentionsLegales>();
                MentionsLegales = _db.MentionsLegales.ToList();
            }
            return MentionsLegales;
        }

        public MentionsLegales GetById(Guid id)
        {
            MentionsLegales MentionsLegales = null;
            using (_db)
            {
                MentionsLegales = new MentionsLegales();
                MentionsLegales = _db.MentionsLegales.FirstOrDefault(d => d.IsHistorique && d.Id == id);
            }
            return MentionsLegales; 
        }

        public void Post(MentionsLegales entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.MentionsLegales.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Put(MentionsLegales entity)
        {
            using (_db)
            {
                _db.MentionsLegales.Update(entity);
                _db.SaveChanges();
            }
        }

      

       
    }
}