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
            List<Stock> Stocks = null;

            using (_db)
            {
                Stocks = new List<Stock>();
                Stocks = _db.Stocks.ToList();
            }
            return Stocks;
        }

        public Stock GetById(int id)
        {
            Stock Stock = null;
            using (_db)
            {
                Stock = new Stock();
                Stock = _db.Stocks.FirstOrDefault(d => d.Id == id);
            }
            return Stock;
        }

        public void Post(Stock entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.Stocks.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Put(Stock entity)
        {
            throw new NotImplementedException();
        }
    }
}
