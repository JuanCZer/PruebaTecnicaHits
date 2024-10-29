using Newtonsoft.Json;
using PruebaTecnicaHits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaHits.Rest
{
    public class RestServices
    {
        private readonly HttpClient _httpClient;

        public RestServices()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Pelicula>> GetPeliculasSectionAAsync()
        {
            try
            {
                var url = "https://api.jsonbin.io/v3/b/6670b6abe41b4d34e404c0bd";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                    return apiResponse.Record?.Response?.Peliculas ?? new List<Pelicula>();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return new List<Pelicula>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Pelicula>();
            }
        }

        public async Task<List<Pelicula>> GetPeliculasSectionBAsync()
        {
            try
            {
                var url = "https://api.jsonbin.io/v3/b/6670b55be41b4d34e404c04d";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                    return apiResponse.Record?.Response?.Peliculas ?? new List<Pelicula>();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return new List<Pelicula>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Pelicula>();
            }
        }

        public async Task<List<Pelicula>> GetPeliculasSectionCAsync()
        {
            try
            {
                var url = "https://api.jsonbin.io/v3/b/6670b60cad19ca34f87a78d2";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                    return apiResponse.Record?.Response?.Peliculas ?? new List<Pelicula>();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return new List<Pelicula>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Pelicula>();
            }
        }

        public async Task<List<Pelicula>> GetPeliculasSectionDAsync()
        {
            try
            {
                var url = "https://api.jsonbin.io/v3/b/6670b67cad19ca34f87a78ed";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                    return apiResponse.Record?.Response?.Peliculas ?? new List<Pelicula>();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return new List<Pelicula>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Pelicula>();
            }
        }
    }
}
