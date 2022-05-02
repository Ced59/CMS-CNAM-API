using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.UsersDto
{
    public class UserDto : UserPostDto
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
    }
}
