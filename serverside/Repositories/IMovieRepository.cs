using System.Collections.Generic;
using System.Threading.Tasks;
using serverside.Models;

public interface IMovieRepository
{
    Task<MovieResult> GetMoviesAsync();
    Task<Movie> GetMovieAsync(int Id);
    Task<MovieResult> SearchMovieAsync(string query);
    
}