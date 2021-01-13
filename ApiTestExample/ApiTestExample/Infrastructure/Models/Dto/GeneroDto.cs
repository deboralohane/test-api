using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTestExample.Infrastructure.Models.Dto
{
    public class GeneroDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}
