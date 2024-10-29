using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaHits.Models
{
    public class ApiResponse
    {
        [JsonProperty("record")]
        public Record Record { get; set; }
    }

    public class Record
    {
        [JsonProperty("response")]
        public Response Response { get; set; }
    }

    public class Response
    {
        [JsonProperty("groups")]
        public List<Pelicula> Peliculas { get; set; }
    }
    public class Pelicula
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("title_original")]
        public string title_original { get; set; }
        
        [JsonProperty("description_large")]
        public string description_large { get; set; }

        [JsonProperty("image_small")]
        public string image_small { get; set; }

        [JsonProperty("image_medium")]
        public string image_medium { get; set; }

        [JsonProperty("image_large")]
        public string image_large { get; set; }

        [JsonProperty("duration")]
        public string duration { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }
    }


}
