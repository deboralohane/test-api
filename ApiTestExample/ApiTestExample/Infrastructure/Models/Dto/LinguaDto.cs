using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTestExample.Infrastructure.Models.Dto
{
    public class LinguaDto
    {
        [JsonProperty("english_name")]
        public string NomeEmIngles { get; set; }

        [JsonProperty("iso_639_1")]
        public string Sigla { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}
