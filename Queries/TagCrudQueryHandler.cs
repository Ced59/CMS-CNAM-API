using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.TagsEntitie;
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

        public IEnumerable<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Tag entity)
        {
            throw new NotImplementedException();
        }

        public void Put(Tag entity)
        {
            throw new NotImplementedException();
        }
    }
}
