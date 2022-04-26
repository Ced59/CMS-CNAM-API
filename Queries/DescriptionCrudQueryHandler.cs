using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.DescriptionsEntitie;
using Microsoft.EntityFrameworkCore;
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
            List<Description> Descriptions = null;
            using (_db)
            {
                Descriptions = new List<Description>();
                Descriptions = _db.Descriptions.ToList();
            }
            return Descriptions;
        }

        public Description GetById(int id)
        {
            Description Descriptions = null;
            using (_db)
            {
                Descriptions = new Description();
                Descriptions = _db.Descriptions.FirstOrDefault(d => d.IsActif && d.Id == id);
            }
            return Descriptions;
        }

        public Description GetByProductId(int idProduct)
        {
            Description Descriptions = null;
            using (_db)
            {
                Descriptions = new Description();
                Descriptions = _db.Descriptions.FirstOrDefault(d=>d.IsActif && d.Produit.IsActif && d.Produit.Id == idProduct);
            }
            return Descriptions;
        }

        public void Post(Description entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.Descriptions.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Put(Description entity)
        {
            throw new NotImplementedException();
        }
    }
}
