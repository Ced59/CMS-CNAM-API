using Entities.DatabasesContext;
using Entities.UsersEntities;
using Queries.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Queries
{
    public class UserCrudQueryHandler : ICrudInterface<User>
    {
        private readonly DatabaseContext _db;

        public UserCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Archive(Guid id)
        {
            User user = new User();
                user =_db.Users.FirstOrDefault(u => u.Id == id);
            user.IsArchived = true;
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User GetById(Guid id)
        {
            return _db.Users.FirstOrDefault(e => e.Id == id);
        }

        public void Post(User entity)
        {
            _db.Users.Add(entity);
            _db.SaveChanges();
        }

        public void Put(User entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}
