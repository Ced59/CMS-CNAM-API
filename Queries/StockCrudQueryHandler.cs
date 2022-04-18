using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CommentairesEntities;
using Entities.DatabasesContext;
using Entities.StocksEntitie;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Queries.Interface;

namespace Queries
{
    public class StockCrudQueryHandler : ICrudInterface<Stock>
    {
        private readonly DatabaseContext _db;
        public StockCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public IEnumerable<Stock> GetAll()
        {
            throw new NotImplementedException();
        }

        public Stock GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Stock entity)
        {
            throw new NotImplementedException();
        }

        public void Put(Stock entity)
        {
            throw new NotImplementedException();
        }
    }
}
