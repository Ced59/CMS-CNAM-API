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
    public class ImageCrudQueryHandler : ICrudInterface<Image>
    {
        private readonly DatabaseContext _db;
        public ImageCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Archive(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetAll()
        {
            List<Image> Images = null;

            using (_db)
            {
                Images = new List<Image>();
                Images = _db.Images.ToList();
            }
            return Images;
        }

        public Image GetById(Guid id)
        {
            Image Image = null;
            using (_db)
            {
                Image = new Image();
                Image = _db.Images.FirstOrDefault(d => !d.IsArchived && d.Id == id);
            }
            return Image;
        }

        public void Post(Image entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.Images.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Put(Image entity)
        {
            using (_db)
            {
                _db.Images.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
