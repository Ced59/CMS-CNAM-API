using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UsersEntities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PasswordId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pseudo { get; set; }
        public string Gender { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UrlPhoto { get; set; }
        public bool IsArchived { get; set; }
        public bool IsAdmin { get; set; }

        public static string GeneratePassword(string guid, string pwd)
        {
            char[] charGuid = guid.ToCharArray();
            char[] charPwd = pwd.ToCharArray();

            StringBuilder blr = new StringBuilder();

            for (int i = 0; i <= charPwd.Count() - 1; i++)
            {
                blr.Append(charPwd[i]);
                if (i <= charGuid.Count() - 1)
                    blr.Append(charGuid[i]);
            }

            string salt = blr.ToString();
            byte[] hashedBytes;

            blr = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                hashedBytes = hash.ComputeHash(enc.GetBytes(salt));
            }

            foreach (byte b in hashedBytes)
                blr.Append(b.ToString("x2"));

            string hashedPwd = blr.ToString();

            return hashedPwd;
        }

        public static bool CheckPassword(string guid, string pwd, string hashedPwd)
        {
            if (GeneratePassword(guid, pwd) == hashedPwd)
                return true;
            else
            {
                return false;
            }
        }
    }

    public class Credential
    {
        public string login { get; set; }
        public string pwd { get; set; }
    }


}
