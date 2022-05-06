using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.UsersDto
{
    public class UserBase
    {
        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "pseudo")]
        public string Pseudo { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "urlPhoto")]
        public string UrlPhoto { get; set; }

        [JsonProperty(PropertyName = "isAdmin")]
        public bool IsAdmin { get; set; }
    }
}
