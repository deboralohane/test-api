using ApiTestExample.Infrastructure.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTestExample.Infrastructure.Services.Models
{
    public class GetMovieDetailsResponse
    {
        [JsonProperty("adult")]
        public bool Adulto { get; set; }

        [JsonProperty("backdrop_path")]
        public string ImagemDeFundo { get; set; }

        //[JsonProperty("belongs_to_collection")]
        //public string PertenceColecao { get; set; }

        [JsonProperty("budget")]
        public float Orcamento { get; set; }

        [JsonProperty("genres")]
        public List<GeneroDto> Genero { get; set; }

        [JsonProperty("homepage")]
        public string PaginaInicial { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imdb_id")]
        public string IMDB_Id { get; set; }

        [JsonProperty("original_language")]
        public string LinguagemOriginal { get; set; }

        [JsonProperty("original_title")]
        public string TituloOriginal { get; set; }

        [JsonProperty("overview")]
        public string Sinopse { get; set; }

        [JsonProperty("popularity")]
        public float Popularidade { get; set; }

        [JsonProperty("poster_path")]
        public string Poster { get; set; }

        [JsonProperty("production_companies")]
        public List<ProducaoEmpresaDto> ProducaoEmpresas { get; set; }

        [JsonProperty("production_countries")]
        public List<ProducaoPaisDto> ProducaoPais { get; set; }

        [JsonProperty("release_date")]
        public string DataLancamento { get; set; }

        [JsonProperty("revenue")]
        public float Receita { get; set; }

        [JsonProperty("runtime")]
        public int TempoDeExecucao { get; set; }

        [JsonProperty("spoken_languages")]
        public List<LinguaDto> Linguas { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Slogan { get; set; }

        [JsonProperty("title")]
        public string Titulo { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public float MediaDeVotos { get; set; }

        [JsonProperty("vote_count")]
        public float ContagemDeVotos { get; set; }

    }
}
