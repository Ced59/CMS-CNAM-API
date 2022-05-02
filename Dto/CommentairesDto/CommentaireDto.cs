using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dto.CommentairesDto
{
    public class CommentaireDto
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "note")]
        public int Note { get; set; }

        [JsonProperty(PropertyName = "idProduit")]
        public Guid ProduitId { get; set; }

        [JsonProperty(PropertyName = "idUser")]
        public Guid UserId { get; set; }
    }
}
