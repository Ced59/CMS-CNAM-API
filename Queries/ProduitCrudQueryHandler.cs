using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.ProduitsEntitie;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Queries.Interface;

namespace Queries
{
    public class ProduitCrudQueryHandler : ICrudInterface<Produit>
    {
        private readonly DatabaseContext _db;
        public ProduitCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public IEnumerable<Produit> GetAll()
        {
            throw new NotImplementedException();
        }

        public Produit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Produit entity)
        {
            throw new NotImplementedException();
        }

        public void Put(Produit entity)
        {
            throw new NotImplementedException();
        }
    }
}
