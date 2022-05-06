using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using Entities.DatabasesContext;
using Entities.UsersEntities;

namespace WebAPI.DatabaseService
{
    public class ServiceDatabaseDatas
    {
        private readonly DatabaseContext _client;

        public ServiceDatabaseDatas()
        {
            _client = new DatabaseContext();
        }

        public void GenerateDbDatas()
        {
            if (_client.Users.ToList().Count == 0)
            {
                InsertFakeDatas();
            }
        }

        private void InsertFakeDatas()
        {
            var users = GenerateFakeUsers();



            SaveUsers(users);
        }

        private static IEnumerable<User> GenerateFakeUsers()
        {
            var users = new List<User>();

            var faker = new Faker("fr");

            var admin = new User()
            {
                Id = Guid.NewGuid(),
                LastName = "AdminLastName",
                FirstName = "AdminFirstName",
                Login = "admin@test.com",
                Password = "password",
                UrlPhoto = faker.Person.Avatar,
                IsArchived = false,
                IsAdmin = true,
                Gender = "Mr"
            };

            users.Add(admin);

            faker = new Faker("fr");

            var user = new User()
            {
                Id = Guid.NewGuid(),
                LastName = "UserLastName",
                FirstName = "UserFirstName",
                Login = "user@test.com",
                Password = "password",
                UrlPhoto = faker.Person.Avatar,
                IsArchived = false,
                IsAdmin = false,
                Gender = "Mr"
            };

            users.Add(user);

            for (var i = 0; i <= 100; i++)
            {
                faker = new Faker("fr");
                users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    LastName = faker.Person.LastName,
                    FirstName = faker.Person.FirstName,
                    Login = faker.Person.UserName,
                    Password = "password",
                    UrlPhoto = faker.Person.Avatar,
                    IsArchived = faker.Random.Bool(),
                    IsAdmin = false,
                    Gender = faker.Person.Gender.ToString()
                });
            }

            return users;
        }

        private void SaveUsers(IEnumerable<User> users)
        {
            _client.Users.AddRange(users);
            _client.SaveChanges();
        }
    }
}
