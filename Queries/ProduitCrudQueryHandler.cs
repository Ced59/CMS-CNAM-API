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
            List<Produit> Produits = null;

            using (_db)
            {
                Produits = new List<Produit>();
                Produits = _db.Produits.ToList();
            }
            return Produits;
        }

        public Produit GetById(int id)
        {
            Produit Produit = null;
            using (_db)
            {
                Produit = new Produit();
                Produit = _db.Produits.FirstOrDefault(d => d.IsActif && d.Id == id);
            }
            return Produit;
        }

        public void Post(Produit entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.Produits.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Put(Produit entity)
        {
            throw new NotImplementedException();
        }
    }
}
