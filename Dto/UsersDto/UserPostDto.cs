using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.UsersDto
{
    public class UserPostDto : UserBase
    {

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "passwordCheck")]
        public string PasswordCheck { get; set; }

    }
}
