using Dto.UsersDto;
using Entities.DatabasesContext;
using Entities.UsersEntities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Queries;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Helpers;

namespace WebAPI.Extensions
{
    public class UserService
    {
        private readonly AppSettings _appSettings;
        private User _user;
        private readonly UserCrudQueryHandler _db;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _user = new User();
            _db = new UserCrudQueryHandler();
        }

        public AuthenticateResponse Authenticate(Credential model)
        {
            _user = _db.Login(model.login, model.pwd);

            // return null if user not found
            if (_user == null) return null;

            // authentication successful so generate jwt token
            string token = GenerateJwtToken(_user);

            return new AuthenticateResponse(_user, token);
        }

        private string GenerateJwtToken(User user)
        {
            // generate token that is valid for 6 hours
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
