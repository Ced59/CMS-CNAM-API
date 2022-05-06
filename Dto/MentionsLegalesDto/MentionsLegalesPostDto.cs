using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dto.MentionsLegalesDto
{
    public class MentionsLegalesPostDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "mention")]
        public string Mentions { get; set; }

        [JsonProperty(PropertyName = "DateAjout")]
        public DateTime DateAjout { get; set; }
    }
}
