using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTestExample.Infrastructure.Models.Dto
{
    public class ProducaoPaisDto
    {

        [JsonProperty("iso_3166_1")]
        public string Sigla { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}
