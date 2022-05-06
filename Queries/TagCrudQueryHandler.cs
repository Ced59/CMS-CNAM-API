using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DatabasesContext;
using Entities.ProduitsEntities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Queries.Interface;

namespace Queries
{
    public class TagCrudQueryHandler : ICrudInterface<Tag>
    {
        private readonly DatabaseContext _db;
        public TagCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Archive(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            List<Tag> Tags = null;

            using (_db)
            {
                Tags = new List<Tag>();
                Tags = _db.Tags.ToList();
            }
            return Tags;
        }

        public Tag GetById(Guid id)
        {
            Tag Tag = null;
            using (_db)
            {
                Tag = new Tag();
                Tag = _db.Tags.FirstOrDefault(d => !d.IsArchived && d.Id == id);
            }
            return Tag;
        }

        public void Post(Tag entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.Tags.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Put(Tag entity)
        {
            using (_db)
            {
                _db.Tags.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
