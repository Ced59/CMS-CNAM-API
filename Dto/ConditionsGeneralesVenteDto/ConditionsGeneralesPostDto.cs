﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dto.ConditionsGeneralesVenteDto
{
    public class ConditionsGeneralesPostDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "condition")]
        public string Conditions { get; set; }

        [JsonProperty(PropertyName = "DateAjout")]
        public DateTime DateAjout { get; set; }

    }
}