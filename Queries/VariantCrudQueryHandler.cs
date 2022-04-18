using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.VariantsEntitie;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Queries.Interface;

namespace Queries
{
    public class VariantCrudQueryHandler : ICrudInterface<Variant>
    {
        private readonly DatabaseContext _db;
        public VariantCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public IEnumerable<Variant> GetAll()
        {
            throw new NotImplementedException();
        }

        public Variant GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Variant entity)
        {
            throw new NotImplementedException();
        }

        public void Put(Variant entity)
        {
            throw new NotImplementedException();
        }
    }
}
