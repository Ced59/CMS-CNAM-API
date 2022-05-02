using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Queries.Interface;

namespace Queries
{
    public class CommentaireCrudQueryHandler : ICrudInterface<Commentaire>
    {
        private readonly DatabaseContext _db;
        public CommentaireCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Post(Commentaire entity)
        {
            _db.Commentaires.Add(entity);
            _db.SaveChanges();
        }

        public Commentaire GetById(int id)
        {
            return _db.Commentaires.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Commentaire> GetAll()
        {
             return _db.Commentaires;
        }

        public void Put(Commentaire entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

    }
}
