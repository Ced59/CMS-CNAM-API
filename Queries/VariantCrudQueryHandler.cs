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
            List<Variant> Variants = null;

            using (_db)
            {
                Variants = new List<Variant>();
                Variants = _db.Variants.ToList();
            }
            return Variants;
        }

        public Variant GetById(int id)
        {
            Variant Variant = null;
            using (_db)
            {
                Variant = new Variant();
                Variant = _db.Variants.FirstOrDefault(d => d.IsActif && d.Id == id);
            }
            return Variant;
        }

        public void Post(Variant entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.Variants.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Put(Variant entity)
        {
            using (_db)
            {
                _db.Variants.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
