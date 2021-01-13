using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTestExample.Infrastructure.Models.Dto
{
    public class ProducaoEmpresaDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("logo_path")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("origin_country")]
        public string PaisOriginal { get; set; }

    }
}
