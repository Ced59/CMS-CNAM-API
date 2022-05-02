using Entities.DatabasesContext;
using Entities.UsersEntities;
using Queries.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            User user = _db.Users.FirstOrDefault(u => u.Id == id);
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
            return _db.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetByLogin(string login)
        {
            return _db.Users.FirstOrDefault(u => u.Login == login);
        }

        public void Post(User entity)
        {
            entity.Id = Guid.NewGuid();
            entity.PasswordId = Guid.NewGuid();
            entity.Password = User.GeneratePassword(entity.PasswordId.ToString(), entity.Password);
            entity.IsArchived = false;
            _db.Users.Add(entity);
            _db.SaveChanges();
        }

        public void Put(User entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

        public User Login(string email, string pwd)
        {
            User user = GetByLogin(email);
            if (user != null && User.CheckPassword(user.PasswordId.ToString(), pwd, user.Password))
            {
                return user;
            }
            else
            {
                return null;
            }

        }
    }
}
