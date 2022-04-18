using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.DescriptionsEntitie;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Queries.Interface;

namespace Queries
{
    public class DescriptionCrudQueryHandler : ICrudInterface<Description>
    {
        private readonly DatabaseContext _db;
        public DescriptionCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public IEnumerable<Description> GetAll()
        {
            throw new NotImplementedException();
        }

        public Description GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Description entity)
        {
            throw new NotImplementedException();
        }

        public void Put(Description entity)
        {
            throw new NotImplementedException();
        }
    }
}
