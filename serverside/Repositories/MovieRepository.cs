using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using serverside.Models;

namespace Repositories
{

    public class MovieRepository : IMovieRepository
    {
        private static string baseUrl = "https://api.themoviedb.org/";
        private static string apikey = "ff5da47c3874a99797d7e2aeef635c13";

        static HttpClient client = new HttpClient();

        public async Task<MovieResult> GetMoviesAsync()
        {

            MovieResult movies = null;
            HttpResponseMessage response = await client.GetAsync(baseUrl + "3/movie/popular?api_key=" + apikey);
            if (response.IsSuccessStatusCode)
            {
                movies = await response.Content.ReadAsAsync<MovieResult>();
            }
            return movies;

        }
        public async Task<Movie> GetMovieAsync(int Id)
        {


            Movie movie = null;
            HttpResponseMessage response = await client.GetAsync(baseUrl + "3/movie/" + Id + "?api_key=" + apikey);
            if (response.IsSuccessStatusCode)
            {
                movie = await response.Content.ReadAsAsync<Movie>();
            }
            return movie;

        }

        public async Task<MovieResult> SearchMovieAsync(string query)
        {


            //MovieResult movie = null;
            HttpResponseMessage response = await client.GetAsync(baseUrl + "3/search/movie?api_key=" + apikey + "&query=" + query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<MovieResult>();
            }
            return default(MovieResult);

        }
    }

}


