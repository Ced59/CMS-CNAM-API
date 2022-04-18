using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.ImagesEntitie;
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

        public IEnumerable<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Image entity)
        {
            throw new NotImplementedException();
        }

        public void Put(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
