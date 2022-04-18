using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entities.VariantsEntitie;
using Microsoft.AspNetCore.DataProtection;

namespace Queries.Interface
{
    public interface ICrudInterface<T> where T : class
    {
        public void Post(T entity);
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public void Put(T entity);
    }
}
