using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.UsersEntities
{
    public class AuthenticateResponse
    {
        public Guid Id { get; set; }
        public string Pseudo { get; set; }
        public string Login { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Login = user.Login;
            Pseudo = user.Pseudo;
            Token = token;
        }
    }
}
