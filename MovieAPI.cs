using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieAPI
{
    internal class MovieAPI
    {
        private readonly string apiKey = "b444d415";           
        private readonly HttpClient httpClient = new HttpClient();

        public class Movie
        {
            public string Title { get; set; }
            public string Year { get; set; }
        }

        //public async Task<string> SearchMoviesAsync(string query)
        //{
        //    string url = $"http://www.omdbapi.com/?s={query}&apikey={apiKey}";

        //    HttpResponseMessage response = await httpClient.GetAsync(url);
        //    response.EnsureSuccessStatusCode(); 

        //    string jsonResponse = await response.Content.ReadAsStringAsync();
        //    //return await response.Content.ReadAsStringAsync();

        //    dynamic json = JsonConvert.DeserializeObject(jsonResponse);
        //    List<Movie> movies = new List<Movie>();

        //        if (json?.Search != null)
        //        {
        //                foreach (var item in json.Search)
        //                {
        //                    movies.Add(new Movie
        //                    {
        //                        Title = item.Title,
        //                        Year = item.Year
        //                    });

        //                }

        //        }

        //return movies;
        //}
        public async Task<string> SearchMoviesAsync(string query)
        {

            using (HttpClient client = new HttpClient())

                {
                    string url = $"http://www.omdbapi.com/?s={query}&apikey={apiKey}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync(); // Return the JSON string
            }
        }
        public async Task<string> GetMovieDetailsAsync(string imdbId)
            {
                string url = $"http://www.omdbapi.com/?i={imdbId}&apikey={apiKey}";
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
    }
}

